package com.example.smartorganizer;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

public class LoginActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        Button loginButton = findViewById(R.id.loginButton);
        loginButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Symulacja udanego logowania
                boolean isAuthenticated = true;

                if (isAuthenticated) {
                    Intent intent = new Intent(LoginActivity.this, CalendarActivity.class);
                    startActivity(intent);
                } else {
                    Toast.makeText(LoginActivity.this, "Logowanie nieudane. Spróbuj ponownie.", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}