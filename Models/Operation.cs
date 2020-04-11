using System.ComponentModel.DataAnnotations;

public class Operation  
{  
    //Числа
    [Display( Name = "First Number" )]  
    public float FirstNumber { get; set; } 

    [Display( Name = "Second Number" )]  
    public float SecondNumber { get; set; } 
     
    //Результаты вычислений
    [Display( Name = "Addition" )]  
    public float Addition { get; set; }  

    [Display( Name = "Substraction" )]  
    public float Substraction { get; set; }  

    [Display( Name = "Division" )]  
    public float Division { get; set; }

    [Display( Name = "Multiplication" )]  
    public float Multiplication { get; set; }  
}  
