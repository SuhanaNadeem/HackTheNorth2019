package com.google.ar.sceneform.samples.solarsystem;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

//import com.google.ar.sceneform.samples.solarsystem.R;


public class SprayPaint   extends AppCompatActivity{

    private static final String TAG = "DemoSprayPaint";

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_solar);

        // Code for the button to perform

        Button btn = (Button) findViewById(R.id.btnPaint);

        // Code what happens when the user clicks the button

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.i(TAG, "Paint test message!");
                Toast.makeText(getApplicationContext(), "It's some paint!", Toast.LENGTH_SHORT).show();
            }
        });
    }

}