var form1 = document.querySelector('#login')
var form2 = document.querySelector('#sign-up')
var email = document.getElementById('enter-email')
var emaildk = document.getElementById('enter-email-sign-up')
var address = document.getElementById('enter-address')
var password = document.getElementById('enter-password')
var passworddk = document.getElementById('enter-password-sign-up')
var fname = document.getElementById('enter-fullname')
var password2 = document.getElementById('enter-password-again')

form1.addEventListener('submit', e => {
    e.preventDefault();

    checkInputsForm1();
});

form2.addEventListener('submit', e => {
    e.preventDefault();

    checkInputsForm2();
});

function checkInputsForm1() {
    let emailValue = email.value.trim();
    let passwordValue = password.value.trim();
    if (emailValue === '') {
        setErrorFor(email, 'Email không được để trống!!!')
    } else if (!isEmail(emailValue)) {
        setErrorFor(email, 'Email không hợp lệ');
    } else {
        setSuccessFor(email);
    }
    if (passwordValue.length < 6) {
        setErrorFor(password, 'Mật khẩu phải lớn hơn 6 kí tự');
    } else {
        setSuccessFor(password);
    }
}

function checkInputsForm2() {
    let fnameValue = fname.value.trim();
    let emailValue = emaildk.value.trim();
    let addressValue = address.value.trim();
    let passwordValue = passworddk.value.trim();
    let password2Value = password2.value.trim()
    if (fnameValue === '') {
        setErrorFor(fname, 'Họ tên không được để trống');
    } else {
        setSuccessFor(fname);
    }
    if (addressValue === '') {
        setErrorFor(address, 'Địa chỉ không được để trống');
    } else {
        setSuccessFor(address);
    }

    if (emailValue === '') {
        setErrorFor(emaildk, 'Email không được để trống');
    } else if (!isEmail(emailValue)) {
        setErrorFor(emaildk, 'Email không hợp lệ');
    } else {
        setSuccessFor(emaildk);
    }

    if (passwordValue.length < 6) {
        setErrorFor(passworddk, 'Mật khẩu phải lớn hơn 6 ký tự');
    } else {
        setSuccessFor(passworddk);
    }

    if (password2Value === '') {
        setErrorFor(password2, 'Xác nhận mật khẩu không được để trống');
    } else if (passwordValue !== password2Value) {
        setErrorFor(password2, 'Xác nhận mật khẩu không trùng với mật khẩu');
    } else {
        setSuccessFor(password2);
    }
}

function setErrorFor(input, message) {
    const formControl = input.parentElement;
    const small = formControl.querySelector('small');
    formControl.className = 'form-control error';
    small.innerText = message;
}

function setSuccessFor(input) {
    const formControl = input.parentElement;
    formControl.className = 'form-control success';
}

function isEmail(email) {
    return /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(email);
}
