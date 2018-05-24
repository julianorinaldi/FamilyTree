using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        public Person(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Children = new List<Person>();
            Brothers = new List<Person>();
        }

        public Person(string name, Gender gender, Person father, Person mother) : this(name, gender)
        {
            Father = father;
            Mother = mother;

            if (Father != null && !Father.Children.Any(x => x.Name.Equals(name)))
                Father.Children.Add(this);

            if (Mother != null && !Mother.Children.Any(x => x.Name.Equals(name)))
                Mother.Children.Add(this);
        }

        public Person Father { get; set; }
        public Person Mother { get; set; }
        public List<Person> Children { get; private set; }

        public List<Person> Brothers { get; private set; }

        public string Name { get; private set; }
        public Gender Gender { get; private set; }
    }
}
