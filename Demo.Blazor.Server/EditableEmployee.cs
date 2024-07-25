using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Demo.Blazor.Server.Pages
{
    public class EditableEmployee : XPObject
    {
        public EditableEmployee(Session session) : base(session) { }

        private string firstName;
        public string FirstName
        {
            get => firstName;
            set => SetPropertyValue(nameof(FirstName), ref firstName, value);
        }

        private string lastName;
        public string LastName
        {
            get => lastName;
            set => SetPropertyValue(nameof(LastName), ref lastName, value);
        }

        private string position;
        public string Position
        {
            get => position;
            set => SetPropertyValue(nameof(Position), ref position, value);
        }
    }
}

