using Gestionnaire_contacts.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestionnaire_contacts.Database;

public class ContactsDbContext : DbContext
{
    public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options) { }

    public DbSet<Contact> Contacts { get; set; }
}
