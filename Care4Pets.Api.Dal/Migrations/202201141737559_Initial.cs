namespace Care4Pets.Api.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdministrationWays",
                c => new
                    {
                        Id = c.Guid(false),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medications",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(false, 50),
                        Presentation = c.String(true, 50),
                        ExpirationDate = c.DateTime(true),
                        Manufacturer = c.String(true, 50),
                        ManufacturingDate = c.DateTime(true),
                        BatchNumber = c.String(true, 150),
                        UnitPrice = c.Single(nullable: false),
                        SalePrice = c.Single(nullable: false),
                        AdministrationWayId = c.Guid(true),
                        MedicationPresentationId = c.Guid(true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdministrationWays", t => t.AdministrationWayId)
                .ForeignKey("dbo.MedicationPresentations", t => t.MedicationPresentationId)
                .Index(t => t.AdministrationWayId)
                .Index(t => t.MedicationPresentationId);
            
            CreateTable(
                "dbo.MedicationPresentations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Dose = c.String(true, 50),
                        StartDate = c.DateTime(true),
                        EndDate = c.DateTime(true),
                        Frecuency = c.String(true, 50),
                        PetId = c.Guid(true),
                        MedicationId = c.Guid(true),
                        ProfessionalId = c.Guid(true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medications", t => t.MedicationId)
                .ForeignKey("dbo.Pets", t => t.PetId)
                .ForeignKey("dbo.Professionals", t => t.ProfessionalId)
                .Index(t => t.PetId)
                .Index(t => t.MedicationId)
                .Index(t => t.ProfessionalId);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(false, 50),
                        DateOfBirth = c.DateTime(true),
                        Breed = c.String(true, 50),
                        Specie = c.String(true, 50),
                        Gender = c.String(true, 50),
                        Appearance = c.String(true, 50),
                        Sterilized = c.Boolean(nullable: false),
                        DateOfSterilization = c.DateTime(true),
                        Notes = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professionals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(false, 50),
                        Email = c.String(true, 150),
                        Phone = c.String(true, 150),
                        Address = c.String(true, 200),
                        Website = c.String(true, 150),
                        ProfessionId = c.Guid(true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professions", t => t.ProfessionId)
                .Index(t => t.ProfessionId);
            
            CreateTable(
                "dbo.Professions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reminders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Time = c.Int(nullable: false),
                        Unit = c.String(true, 50),
                        Repeat = c.Boolean(nullable: false),
                        RepeatTypeId = c.Int(true),
                        ReminderTypeId = c.Int(true),
                        EventId = c.Guid(true),
                        PrescriptionId = c.Guid(true),
                        FeedingId = c.Guid(true),
                        NotificationTypeId = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId)
                .ForeignKey("dbo.Feedings", t => t.FeedingId)
                .ForeignKey("dbo.NotificationTypes", t => t.NotificationTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Prescriptions", t => t.PrescriptionId)
                .ForeignKey("dbo.ReminderTypes", t => t.ReminderTypeId)
                .ForeignKey("dbo.RepeatTypes", t => t.RepeatTypeId)
                .Index(t => t.RepeatTypeId)
                .Index(t => t.ReminderTypeId)
                .Index(t => t.EventId)
                .Index(t => t.PrescriptionId)
                .Index(t => t.FeedingId)
                .Index(t => t.NotificationTypeId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(false, 50),
                        StartDate = c.DateTime(true),
                        EndDate = c.DateTime(true),
                        AllDay = c.Boolean(nullable: false),
                        Notes = c.String(true, 150),
                        EventTypeId = c.Int(true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventTypes", t => t.EventTypeId)
                .Index(t => t.EventTypeId);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feedings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Quantity = c.Single(nullable: false),
                        Unit = c.String(true, 50),
                        Frecuency = c.String(true, 50),
                        StartDate = c.DateTime(true),
                        EndDate = c.DateTime(true),
                        PetId = c.Guid(true),
                        FoodId = c.Guid(true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Foods", t => t.FoodId)
                .ForeignKey("dbo.Pets", t => t.PetId)
                .Index(t => t.PetId)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(false, 50),
                        ExpirationDate = c.DateTime(true),
                        Manufacturer = c.String(true, 50),
                        ManufacturingDate = c.DateTime(true),
                        Brand = c.String(true, 50),
                        BatchNumber = c.String(true, 150),
                        UnitPrice = c.Single(nullable: false),
                        SalePrice = c.Single(nullable: false),
                        FoodTypeId = c.Int(true),
                        FoodPresentationId = c.Int(true),
                        PetTypeId = c.Int(true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodPresentations", t => t.FoodPresentationId)
                .ForeignKey("dbo.FoodTypes", t => t.FoodTypeId)
                .ForeignKey("dbo.PetTypes", t => t.PetTypeId)
                .Index(t => t.FoodTypeId)
                .Index(t => t.FoodPresentationId)
                .Index(t => t.PetTypeId);
            
            CreateTable(
                "dbo.FoodPresentations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PetTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotificationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReminderTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RepeatTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(false, 50),
                        Description = c.String(true, 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reminders", "RepeatTypeId", "dbo.RepeatTypes");
            DropForeignKey("dbo.Reminders", "ReminderTypeId", "dbo.ReminderTypes");
            DropForeignKey("dbo.Reminders", "PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Reminders", "NotificationTypeId", "dbo.NotificationTypes");
            DropForeignKey("dbo.Reminders", "FeedingId", "dbo.Feedings");
            DropForeignKey("dbo.Feedings", "PetId", "dbo.Pets");
            DropForeignKey("dbo.Foods", "PetTypeId", "dbo.PetTypes");
            DropForeignKey("dbo.Foods", "FoodTypeId", "dbo.FoodTypes");
            DropForeignKey("dbo.Foods", "FoodPresentationId", "dbo.FoodPresentations");
            DropForeignKey("dbo.Feedings", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Reminders", "EventId", "dbo.Events");
            DropForeignKey("dbo.Events", "EventTypeId", "dbo.EventTypes");
            DropForeignKey("dbo.Professionals", "ProfessionId", "dbo.Professions");
            DropForeignKey("dbo.Prescriptions", "ProfessionalId", "dbo.Professionals");
            DropForeignKey("dbo.Prescriptions", "PetId", "dbo.Pets");
            DropForeignKey("dbo.Prescriptions", "MedicationId", "dbo.Medications");
            DropForeignKey("dbo.Medications", "MedicationPresentationId", "dbo.MedicationPresentations");
            DropForeignKey("dbo.Medications", "AdministrationWayId", "dbo.AdministrationWays");
            DropIndex("dbo.Foods", new[] { "PetTypeId" });
            DropIndex("dbo.Foods", new[] { "FoodPresentationId" });
            DropIndex("dbo.Foods", new[] { "FoodTypeId" });
            DropIndex("dbo.Feedings", new[] { "FoodId" });
            DropIndex("dbo.Feedings", new[] { "PetId" });
            DropIndex("dbo.Events", new[] { "EventTypeId" });
            DropIndex("dbo.Reminders", new[] { "NotificationTypeId" });
            DropIndex("dbo.Reminders", new[] { "FeedingId" });
            DropIndex("dbo.Reminders", new[] { "PrescriptionId" });
            DropIndex("dbo.Reminders", new[] { "EventId" });
            DropIndex("dbo.Reminders", new[] { "ReminderTypeId" });
            DropIndex("dbo.Reminders", new[] { "RepeatTypeId" });
            DropIndex("dbo.Professionals", new[] { "ProfessionId" });
            DropIndex("dbo.Prescriptions", new[] { "ProfessionalId" });
            DropIndex("dbo.Prescriptions", new[] { "MedicationId" });
            DropIndex("dbo.Prescriptions", new[] { "PetId" });
            DropIndex("dbo.Medications", new[] { "MedicationPresentationId" });
            DropIndex("dbo.Medications", new[] { "AdministrationWayId" });
            DropTable("dbo.RepeatTypes");
            DropTable("dbo.ReminderTypes");
            DropTable("dbo.NotificationTypes");
            DropTable("dbo.PetTypes");
            DropTable("dbo.FoodTypes");
            DropTable("dbo.FoodPresentations");
            DropTable("dbo.Foods");
            DropTable("dbo.Feedings");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Reminders");
            DropTable("dbo.Professions");
            DropTable("dbo.Professionals");
            DropTable("dbo.Pets");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.MedicationPresentations");
            DropTable("dbo.Medications");
            DropTable("dbo.AdministrationWays");
        }
    }
}
