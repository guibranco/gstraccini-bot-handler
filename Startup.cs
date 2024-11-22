    services.AddHealthChecks()
        .AddRabbitMQ(rabbitConnectionString: Configuration["RabbitMQ:ConnectionString"]);
