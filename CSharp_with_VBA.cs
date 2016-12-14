C# with VBA C Sharp with vba dll with csharp 

File>New Project> Class Library
In the class:
===================
namespace VitoshNamespace
{
    public class Vitosh5
    {
        public int intNumberOne = 10001;
        public int intNumberTwo = 20001;

        public string Information()
        {
            string strResult = intNumberOne + " " + intNumberTwo;
            return strResult;
        }

        public string AdvancedInformation()
        {
            string strResult = "intNumberOne is " + intNumberOne + ". intNumberTwo is " + intNumberTwo;
            return strResult; 
        }

        public string AdvancedInformation2()
        {
            string strResult = "Built by Vityata";
            return strResult;
        }

        public string AdvancedInformation3()
        {
            string strResult = this.AdvancedInformation2() + " YUP!";
            return strResult;
        }
    }
}
===================
	Menu>Project ~~ Properties
		Application> Assembly Information> Checkbox - Make assembly COM-Visible
			The description will be the one showing in VBA libraries
		Build
			Output path
			Checkpox on "Register for COM interop"
===================
F6 (Build Solution)
===================
Then in VBE > Extras>Library>Browse>Take the *.tlb

Insert like this:
	Option Explicit

	Sub TestMe()
		
		Dim objNumbers As New Vitosh5
		
		Debug.Print objNumbers.intnumberone
		Debug.Print objNumbers.intnumbertwo
		Debug.Print objNumbers.Information
		Debug.Print objNumbers.advancedinformation
		Debug.Print objNumbers.advancedinformation2
		Debug.Print objNumbers.AdvancedInformation3

	End Sub

	If something is changed in the Class code:
		-> new release is needed;
		-> reload the Excel File;
		-> reassign
