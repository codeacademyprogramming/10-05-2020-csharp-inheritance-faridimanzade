using System;

namespace Objects_Inheritance
{
    class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
