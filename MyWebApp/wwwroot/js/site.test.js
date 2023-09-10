describe('Form validation', () => {
  beforeEach(() => {
    document.body.innerHTML = `
      <form>
        <input id="inputNumber" type="text">
        <div id="result"></div>
      </form>
    `;
  });

  test('Empty input should show error message', () => {
    $('#inputNumber').val('');
    $('form').submit();
    expect($('#result').html()).toBe('Form not submitted : Please enter a number');
  });

  test('Non-numeric input should show error message', () => {
    $('#inputNumber').val('abc');
    $('form').submit();
    expect($('#result').html()).toBe('Form not submitted : Please enter only numbers');
  });

  test('Negative number input should show error message', () => {
    $('#inputNumber').val('-1');
    $('form').submit();
    expect($('#result').html()).toBe('Form not submitted : Please enter a positive number');
  });

  test('Valid input should make AJAX request and update result container', () => {
    $('#inputNumber').val('42');
    $('form').submit();
    expect($.ajax).toHaveBeenCalledWith({
      type: 'POST',
      url: '/Index',
      data: $('form').serialize(),
      success: expect.any(Function),
      error: expect.any(Function),
    });
    const response = { output: 'hello world' };
    const successCallback = $.ajax.mock.calls[0][0].success;
    successCallback(response);
    expect($('#result').html()).toBe('HELLO WORLD');
  });
});