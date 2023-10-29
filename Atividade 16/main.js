document.getElementById('upperCase').addEventListener('change', function() {
    transformText();
});

document.getElementById('lowerCase').addEventListener('change', function() {
    transformText();
});

function transformText() {
    const inputText = document.getElementById('inputText').value;
    const upperCaseCheckbox = document.getElementById('upperCase');
    const lowerCaseCheckbox = document.getElementById('lowerCase');

    if (upperCaseCheckbox.checked) {
        document.getElementById('inputText').value = inputText.toUpperCase();
    } else if (lowerCaseCheckbox.checked) {
        document.getElementById('inputText').value = inputText.toLowerCase();
    } else {
        document.getElementById('inputText').value = inputText;
    }
}