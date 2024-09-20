package com.example.dogsproject
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView
import android.widget.Toast
import androidx.recyclerview.widget.GridLayoutManager
import androidx.recyclerview.widget.RecyclerView
class MainActivity : AppCompatActivity(), CardAdapter.OnItemClickListener
{
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val data = listOf("Такса", "Корги", "Лабрадор",
            "Мопс") // Пример данных
        val imageResources = listOf(R.drawable.raksa,
            R.drawable.corgi,
            R.drawable.labro,
            R.drawable.mops) // Пример ресурсов изображений
        val recyclerView = findViewById<RecyclerView>(R.id.imageRecyclerView)
        recyclerView.layoutManager = GridLayoutManager(this, 2)
        recyclerView.adapter = CardAdapter(data, imageResources,this)
    }
    override fun onItemClick(text: String) {
        val infoText = findViewById<TextView>(R.id.textView)
        infoText.text = "Порода собаки: $text"
    }
}