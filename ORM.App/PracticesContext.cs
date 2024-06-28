using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ORM.App;

public partial class PracticesContext : DbContext
{
    public PracticesContext()
    {
    }

    public PracticesContext(DbContextOptions<PracticesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<CourseEnrollment> CourseEnrollments { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Practices;Integrated Security=true; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC27C30E8190");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FullName)
                .HasMaxLength(40)
                .HasColumnName("FULL_NAME");
        });

        modelBuilder.Entity<CourseEnrollment>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.CourseId }).HasName("PK__Course_E__8189DD68CE4E4F32");

            entity.ToTable("Course_Enrollment");

            entity.Property(e => e.StudentId).HasColumnName("Student_id");
            entity.Property(e => e.CourseId).HasColumnName("Course_id");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC271BC4EDF8");

            entity.HasIndex(e => e.Email, "UQ__Customer__161CF72446140416").IsUnique();

            entity.HasIndex(e => e.Phonenumber, "UQ__Customer__8F2B07B1C22C23AD").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(13)
                .HasColumnName("PHONENUMBER");
            entity.Property(e => e.Surname)
                .HasMaxLength(30)
                .HasColumnName("SURNAME");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3214EC27B7E13B0E");

            entity.HasIndex(e => e.DName, "UQ__Departme__47F5D3BE3F7A2403").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DName)
                .HasMaxLength(100)
                .HasColumnName("D_NAME");
            entity.Property(e => e.DirectorName)
                .HasMaxLength(50)
                .HasDefaultValue("T.Y.ANDERSON")
                .HasColumnName("DIRECTOR_NAME");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC27B782E3EC");

            entity.ToTable("EMPLOYEES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("FULL_NAME");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("SALARY");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__EMPLOYEES__DEPAR__4222D4EF");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC27B2C797E3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Order_Date");
            entity.Property(e => e.OrderStatusId)
                .HasDefaultValue(2)
                .HasColumnName("OrderStatusID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Orders__CUSTOMER__4AB81AF0");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderStatusId)
                .HasConstraintName("FK__Orders__OrderSta__4BAC3F29");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order_St__3214EC275DC5A140");

            entity.ToTable("Order_Status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SName)
                .HasMaxLength(20)
                .HasColumnName("S_NAME");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Persons__3214EC27C6BF1A7C");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Age)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("AGE");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC2782D12F6A");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.ProductName)
                .HasMaxLength(30)
                .HasColumnName("PRODUCT_NAME");

            entity.HasOne(d => d.Department).WithMany(p => p.Products)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Products__DEPART__44FF419A");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Supplier__3214EC27D56FE841");

            entity.HasIndex(e => e.CompanyName, "UQ__Supplier__9BCE05DC005D88AF").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Supplier__A9D10534874297BC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
