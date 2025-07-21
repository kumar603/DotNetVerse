using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.Fundementals
{
    /*****************************************************************************************************
         Writer       : Kiran Kumar J
         Description  : Learn how to manage Exception in c# using try catch blocks to ensure app
                        is stable and able to gracefully handle runtime errors
         Created Date : 21 - July - 2025
         Created By   : Kiran Kumar
         Changed Date : 21 - July - 2025
         Changed By   : Kiran Kumar
   *****************************************************************************************************/
    //Exception      :  Exception is a runtime error that disturbs the normal flow of an application 
    //Try - Cide that might cause an exception
    //Catch - code that handles the exception
    //Final block - code that always runs to clear the instance and memory allocations
    //Types of exceptions : NullReference,Dividebyzero,IndexoutofRange,Filenotfound
    internal class ExceptionManagement
    {
        internal void ExceptionManagementWithSingleTryCatchExample()
        {
            try
            {
                int x = 2024;
                int y = 0;
                int result = x / y;
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Final block executed - code executes always even if code getting error or not error");
            }
        }
        internal void ExceptionManagementWithSingleTryMultiCatchExample()
        {
            try
            {
                int x = 2024;
                int y = 0;
                int result = x / y;
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {

                Console.WriteLine("General Error : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Final block executed - code executes always even if code getting error or not error");
            }
        }

        internal void ExceptionManagementWithSingleTryMultiOrderCatchExample()
        {
            try
            {
                int x = 2024;
                int y = 0;
                int result = x / y;
            }

            catch (Exception ex)
            {

                Console.WriteLine("General Error : " + ex.Message);
            }
            //If add this catch will get compile error
            //A previous catch clause already catches all exceptions of this or of a super type ('Exception')
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine("Cannot divide by zero");
            //}
           
            finally
            {
                Console.WriteLine("Final block executed - code executes always even if code getting error or not error");
            }
        }
    }
}
