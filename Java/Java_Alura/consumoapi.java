import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.io.IOException;

public class consumindoap {
        public static void main (String[] args) throws IOException, InterruptedException {
                HttpClient client = HttpClient.newHttpClient();
         	  HttpRequest request = HttpRequest.newBuilder()
             .uri(URI.create("https://www.omdbapi.com/?t=matrix&apikey=6585022c"))
             .build();
        HttpResponse<String> response = client
                .send(request, HttpResponse.BodyHandlers.ofString());
        System.out.println(response.body());
        }
}
