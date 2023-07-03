const api = "https://openexchangerates.org/api/latest.json?app_id=28b685e03d2b4c14a0747bdbc32b8d4d";


// For selecting different controls
let search = document.querySelector(".searchBox");
let convert = document.querySelector(".convert");
const fromCurrency = "ZAR";
const toCurrency = "INR";
let finalValue = document.querySelector(".finalValue");
let searchValue;


search.addEventListener('input', updateValue);

// Function for updating value
function updateValue(e) {
    searchValue = e.target.value;
}


// When user clicks, it calls function getresults
convert.addEventListener("click", getResults);


// Function getresults
function getResults() {
    fetch(`${api}`)
        .then(currency => {
            return currency.json();
        }).then(displayResults);
}

// Display results after conversion
function displayResults(currency) {
    let fromRate = currency.rates[fromCurrency];
    let toRate = currency.rates[toCurrency];
    finalValue.innerHTML =
        ((toRate / fromRate) * searchValue).toFixed(2);
}