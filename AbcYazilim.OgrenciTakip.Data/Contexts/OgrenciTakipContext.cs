using AbcYazilim.OgrenciTakip.Data.OgrenciTakipMigration;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AbcYazilim.OgrenciTakip.Data.Contexts
{
    public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext,Configuration>
    {       
        public OgrenciTakipContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public OgrenciTakipContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false; //performans iyileþtirmesi için kullanýldý.
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Tablolarýn sonuna s eki eklemesi engellendi.
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//Bir e çok iliþkili tablolarda bir veri silindiði zaman diðer taraftan silinmesi engellendi.
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Çok a a çok için ayný iþlem yapldý.
        }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Okul> Okul { get; set; }
    }

}