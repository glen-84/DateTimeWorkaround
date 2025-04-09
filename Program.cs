using HotChocolate.Data.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .ModifyRequestOptions(o => o.IncludeExceptionDetails = builder.Environment.IsDevelopment())
    .AddType<CustomDateTimeType>()
    .BindRuntimeType<DateTime, CustomDateTimeType>()
    .BindRuntimeType<DateTimeOffset, CustomDateTimeType>()
    .AddTypes()
    .AddFiltering(
        c => c
            .AddDefaults()
            .BindRuntimeType<DateTime, CustomDateTimeFilterInputType>()
            .BindRuntimeType<DateTimeOffset, CustomDateTimeFilterInputType>())
    .AddSorting();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);

public sealed class CustomDateTimeFilterInputType
    : ComparableOperationFilterInputType<DateTimeOffset>;
