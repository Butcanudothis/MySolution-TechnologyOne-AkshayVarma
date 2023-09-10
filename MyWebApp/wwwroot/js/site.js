
$(document).ready(function () {
    $('form').submit(function (e) {
        e.preventDefault();
         // form validation for empty input
         if ($('#inputNumber').val() == '') {
            $('#result').html('Form not submitted : Please enter a number');
            return false;
        }
         // form validation for non-numeric input
         if (isNaN($('#inputNumber').val())) {
            $('#result').html('Form not submitted : Please enter only numbers');
            return false;
        }
        // form validation for -ve numbers
        if (parseInt($('#inputNumber').val()) < 0) {
            $('#result').html('Form not submitted : Please enter a positive number');
            return false;
        }

        $.ajax({
            type: 'POST',
            url: '/Index', // URL to the Razor Page
            data: $(this).serialize(),
            success: function (response) {
                // Update the result container with the JSON data
                
                $('#result').html( response.output.toUpperCase() );
            },
            error: function (error) {
                console.error(error);
            }
        });
    });
});