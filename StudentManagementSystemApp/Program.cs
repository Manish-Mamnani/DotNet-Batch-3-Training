// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using StudentManagementSystemApp;
StudentBL sBLobj = new StudentBL();
sBLobj.AcceptStudentDetails();
sBLobj.calcTotal();
sBLobj.calcPerc();

int t1;
float p1;

sBLobj.calcResult(out t1, out p1);

System.Console.WriteLine("Total Marks : " + t1 + "\nPercentage : " + p1+"%");
