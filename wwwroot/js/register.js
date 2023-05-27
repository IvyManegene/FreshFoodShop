$(document).ready(function () {
    debugger;
    $("#registerForm").submit(function (event) {
        event.preventDefault();

        var firstname = $("#firstname").val();
        var lastname = $("#lastname").val();
        var address = $("#address").val();
        var email = $("#email").val();
        var phoneNo = $("#phoneNo").val();
        var password = $("#password").val();

        var data = {
            FirstName: firstname,
            LastName: lastname,
            Address: address,
            Email: email,
            PhoneNumber: phoneNo,
            Password: password
        };

        $.ajax({
            type: "POST",
            url: "https://localhost:44374/api/Customers/Post",
            data: JSON.stringify(data),
            contentType: "application/json",
            success: function (response) {
                alert("Customer registered successfully!");
                // Redirect to the desired page
                window.location.href = "/Login";
            },
            error: function (error) {
                alert("Error occurred during customer registration.");
            }
        });
    });
    $("#loginButton").click(function () {
        // Redirect to the login page
        window.location.href = "/Login";
    });
});
