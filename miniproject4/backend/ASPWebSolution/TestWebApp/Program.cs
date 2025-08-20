namespace TestWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // HTTPClient 등록
            builder.Services.AddHttpClient("MyClient", client =>
            {
                client.BaseAddress = new Uri("https://localhost:8000");     // Python Uvicorn 서비스 URL
            });

            // CORS 허용
            builder.Services.AddCors(options =>
            {
                // 테스트 시에만 사용. 운영때는 실제 아이피, 실제 사용하는 메서드만 허용해야 함
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            builder.Services.AddControllers();  // 컨트롤러 사용 허용
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.UseCors();  // 위에서 설정한 CORS를 사용하겠다
            app.UseDefaultFiles();  // index.html 파일을 자동처리
            app.UseStaticFiles();  // wwwroot 폴더 사용 허용
            app.MapControllers();  // 컨트롤러 기반 매핑(사용)하겠다

            app.Run();
        }
    }
}
