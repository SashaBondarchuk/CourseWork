using System;
using System.Collections.Generic;

namespace CourseWork.Data
{
    public class Base<T> where T : Base<T>
    {
        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();
        public Guid Id { get; protected set; }

        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
        }
        public Base(Guid Id)
        {
            this.Id = Id;
            Items.Add(this.Id, (T)this);
        }
    }
}
