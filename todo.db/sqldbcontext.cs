using Microsoft.EntityFrameworkCore;

namespace todo.db
{
    public class sqldbcontext : DbContext
    {
        public sqldbcontext(DbContextOptions<sqldbcontext> options): base(options)
        {
        }

        public DbSet<TodoItem> TodoItems {get; set;}        
    }
}
