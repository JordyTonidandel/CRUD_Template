namespace CRUDBasicoDotNet.Controllers.PackControllerExample
{
    public class ControllerExample
    {
        public static string Template => "/nameTemplate";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(ControllerExampleRequest nameTemplateRequest)
        {
            var response = new ControllerExampleResponse
            {
                Id = Guid.NewGuid(),
                Name = nameTemplateRequest.Name,
                Active = nameTemplateRequest.Active
            };

            return Results.Created($"/nameTemplate/{nameTemplateRequest.Name}", response);
        }
    }
}
