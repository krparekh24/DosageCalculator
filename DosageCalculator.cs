using System; 
public class DosageCalculator {
     public class CalculationResult { 
        public double TwiceDailyDose { get; set; }
         public double BottleSize { get; set; } 
         public int BottleQuantity { get; set; }
        public int SupplyDays { get; set; } 
        }
 public CalculationResult CalculateDosage(bool isStiripentumab, double weight, double dose) 
 { 
    CalculationResult result = new CalculationResult(); // Check if the patient is taking Stiripentumab
     if (isStiripentumab) 
     { 
     result.TwiceDailyDose = weight* dose * 2 ; // Calculate the twice daily dose in mL 
     result.BottleSize = 500 ; // Define bottle size and quantity based on your calculation 
     result.BottleQuantity = (int)Math.Ceiling(result.TwiceDailyDose / result.BottleSize); // Example bottle size in mL 
     result.SupplyDays = (int)Math.Floor(result.BottleQuantity * 2 / dose); //Calculate how many days the supply will last 
     }
     
      else { 
        // If not taking Stiripentumab, set default values or handle accordingly
        result.TwiceDailyDose = 0 ; 
        result.BottleSize = 0 ; 
        result.BottleQuantity = 0;
        result.SupplyDays = 0; 
      } 
      return result;
 }
}
