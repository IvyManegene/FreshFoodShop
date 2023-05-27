$(document).ready(function () {
    $("#loginForm").submit(function (event) {
        event.preventDefault();

        var email = $("#email").val();
        var password = $("#password").val();

        // Perform input validation
        if (email.trim() === "" || password.trim() === "") {
            alert("Please enter your email and password.");
            return;
        }

        // Perform AJAX request or any necessary login logic here
        // ...

        // Redirect to the products page
        window.location.href = "/products";
    });

    $("#registerButton").click(function () {
        // Redirect to the register page
        window.location.href = "/register";
    });
});
