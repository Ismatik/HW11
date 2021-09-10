using System;

namespace HW11
{
    enum PersonType
    {
        NotSet,
        DocumentWorker,
        ProDocumentWorker,
        ExpertDocumentWorker
    }
    class Program
    {
        static void Main(string[] args)
        {   

            DocumentWorker new1 = null;
            PersonType type = PersonType.NotSet;
            Console.Write("Please choos what you want to do?\n1. Open Document - Enter <<1>>.\n2. Edit Document - Enter <<2>>.\n3. Save document - Enter <<3>>.\n");
            
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": type = PersonType.DocumentWorker; break;
                case "2": 
                    Console.Write("Enter the key: "); 
                    var key = Console.ReadLine();
                    if(key == "ProKey"){
                        type = PersonType.ProDocumentWorker;
                    }
                    else{
                        Console.WriteLine("Key is incorrect!");
                        break;
                    }
                    break;
                case "3": 
                    Console.Write("Enter the key: "); 
                    var key1 = Console.ReadLine();
                    if(key1 == "ExpKey"){
                        type = PersonType.ExpertDocumentWorker;
                    }
                    else{
                        Console.WriteLine("Key is incorrect!");
                        break;
                    }
                    break;
            }
            switch (type)
            {
                case PersonType.DocumentWorker:
                    new1 = new DocumentWorker();
                    break;
                case PersonType.ProDocumentWorker:
                    new1 = new ProDocumentWorker();
                    break;
                case PersonType.ExpertDocumentWorker:
                    new1 =new ExpertDocumentWorker();
                    break;
            }
            new1.Show();

        }
        
        class DocumentWorker
        {
            public virtual void OpenDocument()
            {
                System.Console.WriteLine("Документ открыт.");
            }
            
            public virtual void EditDocument()
            {
                System.Console.WriteLine("Редактирование документа доступно в версии Про");
            }

            public virtual void SaveDocument()
            {
                System.Console.WriteLine("Сохранение документа доступно в версии Про");
            }

            public virtual void Show()
            {
                OpenDocument();
                EditDocument();
                SaveDocument();
            }
        }
        
        class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                System.Console.WriteLine("Документ отредактирован.");
            }
            public override void SaveDocument()
            {
                System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт.");
            }
            public override void Show()
            {
                EditDocument();
                SaveDocument();
            }
        }
        class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                System.Console.WriteLine("Документ сохранен в новом формате");
            }
            public override void Show()
            {
                SaveDocument();
            }
        }
    }
}
