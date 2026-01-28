// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

class student
{
    public void savestudent() { 
        //student save in db
     }
    public void printreport() { 
        //print student
    }
}
//bad example of coding /\


//Good way of SRP

class student2
{
    public String name {  get; set; }
}

class savestudentdata
{
    public void savestudentdb(student std) { }
}

class reportstudent
{
    public void printreport() { }
}

//OCP

class discount
{
    public DoublegetDiscount(String customerType)
    {
        if ()
            return;
        else
    }
}


//best ex of OCP
//to add new discount add new class no need to change before code 
interface IdDiscount
{
    getDiscount(Return;)
}

class studentDiscount : IdDiscount
{
    public getDiscount()=>10
}

class teacherDiscount : IdDiscount
{
    public getDiscount()=>20
}


//LSP

class bird
{
    public virtual void fly()
    {

    }
}

class ostrich : bird
{
    public override void fly()
    {

    }
}


