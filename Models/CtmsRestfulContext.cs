using Microsoft.EntityFrameworkCore;

namespace ctms_restful_2001.Models;

public class CtmsRestfulContext : DbContext
{
    public CtmsRestfulContext(DbContextOptions<CtmsRestfulContext> options)
        : base(options)
    {

    }
}