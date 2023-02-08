// Get elements
const takeNumberBtn = document.getElementById("take-number-btn");
const ticketModal = document.getElementById("ticket-modal");
const close = document.getElementsByClassName("close")[0];
const ticketNumber = document.getElementById("ticket-number");
const counterNumber = document.getElementById("counter-number");

// Open modal when "Take a Number" button is clicked
takeNumberBtn.addEventListener("click", function () {
    ticketModal.style.display = "block";

});

// Close modal when "X" is clicked
close.addEventListener("click", function () {
    ticketModal.style.display = "none";
});

// Close modal when anywhere outside of the modal is clicked
window.addEventListener("click", function (event) {
    if (event.target == ticketModal) {
        ticketModal.style.display = "none";
    }
});
