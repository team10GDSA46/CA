namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodListTable> FoodListTables { get; set; }
        public virtual DbSet<SeasoningTable> SeasoningTables { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<YesNo> YesNoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FoodListTable>()
                .Property(e => e.SizeOfMeal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FoodListTable>()
                .Property(e => e.Pepper)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FoodListTable>()
                .Property(e => e.Chilli)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FoodListTable>()
                .Property(e => e.Ketchup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SeasoningTable>()
                .Property(e => e.Season)
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.Description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<YesNo>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<YesNo>()
                .Property(e => e.Description)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
