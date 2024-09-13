namespace Section4.OverridingCodeFirst
{
    using System.Collections.Generic;

    public partial class Authors
    {
        public Authors()
        {
            Courses = new HashSet<Courses>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}
