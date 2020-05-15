using System;

namespace Objects_Inheritance
{
    class ProDocumentProgram : DocumentProgram
    {
        sealed public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
}
