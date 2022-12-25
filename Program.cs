namespace EmpWageProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuildArray empWageBuildArray = new EmpWageBuildArray();
            empWageBuildArray.addCompanyEmpWage("Deloitte", 20, 15, 60);
            empWageBuildArray.addCompanyEmpWage("Google", 50, 25, 80);
            empWageBuildArray.computeEmpWage();
            
        }
    }
}