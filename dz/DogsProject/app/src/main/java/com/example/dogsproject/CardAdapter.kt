package com.example.dogsproject
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import androidx.recyclerview.widget.RecyclerView
class CardAdapter (private val data: List<String>,private val imageResources:
List<Int>,private val listener: OnItemClickListener) :
    RecyclerView.Adapter<CardAdapter.ViewHolder>() {
    class ViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        val imageView: ImageView = itemView.findViewById(R.id.imageView)
    }
    interface OnItemClickListener {
        fun onItemClick(text: String)
    }
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int):
            ViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.card_element,
            parent, false)
        return ViewHolder(view)
    }
    override fun getItemCount(): Int {
        return data.size
    }
    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        val item = data[position]
        holder.imageView.setImageResource(imageResources[position])
        holder.itemView.setOnClickListener {
            listener.onItemClick(item)
        }
    }
}
