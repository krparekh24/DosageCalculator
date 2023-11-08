document.getElementById("calculate-button").addEventListener("click", function () 
{
    const isStiripentumab = document.getElementById("stiripentumab").checked;
    const weight = parseFloat(document.getElementById("weight").value);
    const dose = parseFloat(document.getElementById("dose").value);
    // Send the user inputs to the server-side (C#) for dosage calculation
    fetch("DosageCalculator.cs/CalculateDosage", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({ isStiripentumab, weight, dose })
    })
        .then(response => response.json())
        .then(data => {
            document.getElementById("twice-daily-dose").textContent = data.twiceDailyDose;
            document.getElementById("bottle-size").textContent = data.bottleSize;
            document.getElementById("bottle-quantity").textContent = data.bottleQuantity;
            document.getElementById("supply-days").textContent = data.supplyDays;
        });
});