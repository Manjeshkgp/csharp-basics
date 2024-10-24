using System;
using System.Diagnostics;

namespace MembersC
{
    class Members
    {
        // member - private fields
        private int salary = 2000;
        private string memberName = "Unknown";

        // member - public fields

        public string company = "Not Provided";

        // member - property : always starts with Capital Letter
        public string JobTitle { set; get; } = "Unset";

        // member - public methods
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                sharingPrivateInfo();
            }
            else
            {
                System.Console.WriteLine("My name is {0} and my jobTitle is {1} and I work at {2}", memberName, JobTitle, company);
            }
        }
        private void sharingPrivateInfo()
        {
            System.Console.WriteLine("My salary is {0}", salary);
        }

        // members - consrtuctor

        public Members(){
            System.Console.WriteLine("Object Created");
        }

        // members - finalizer or destructor (not available in structs, only class)
        ~Members(){
            // cleanup statements
            System.Console.WriteLine("Deconstruction of Members Object");
            Debug.Write("Destruction of Members Obj"); // added since the upper thing happens and deletes itself very quickly can't be seen by human eyes
            // can only be seen in the debug from Visual Studio, not in normal terminal
        }

    }
}