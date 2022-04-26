using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NotesApp.BaseModel
{
    public partial class ModelBase : DbContext
    {
        public ModelBase()
            : base("name=ModelBase")
        {
        }

        public virtual DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
