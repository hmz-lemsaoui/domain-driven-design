namespace WebApi;

public static class UserEndpoints
{

    public static void MapUsrEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("api/users", async (CreateUserCommand command, ISender sender) =>
        {
            Result<Guid> result = await sender.Send(command);

            return result.IsSuccess ? Results.Ok(result.Value) : Results.BadRequest();
        });

    }
}
