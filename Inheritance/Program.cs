using System;

namespace Inheritance
{
    class HomeWork
    {

        static void Main(string[] args)
        {
            Console.Write("choose one of this keywords : basic , pro , expert : ");
            Start: string keyword = Console.ReadLine();
            

            
            switch (keyword)
            {
                case  "basic":
                    DocumentProgram basic = new DocumentProgram();

                    basic.OpenDocument();
                    basic.SaveDocument();
                    basic.EditDocument();

                    break;

                case "pro":
                    ProDocumentProgram pro = new ProDocumentProgram();

                    pro.OpenDocument();
                    pro.EditDocument();
                    pro.SaveDocument();

                    break;

                case "expert":
                    ExpertDocumentProgram expert = new ExpertDocumentProgram();

                    expert.OpenDocument();
                    expert.EditDocument();
                    expert.SaveDocument();

                    break;

                default:
                    goto Start;





            }

         
        }

    }

}

