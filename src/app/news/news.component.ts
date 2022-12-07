import { Component, OnInit } from '@angular/core';
import { Article } from '../Models/ArticleModel';
import { News } from '../Models/NewsModel';
import { ApiService } from '../Services/api.service';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.scss']
})
export class NewsComponent implements OnInit {

  public news = {} as News;
  public selectedArticle = {} as Article;
  constructor(private api:ApiService) { }

  ngOnInit(): void {
    this.getNews()
  }
  getNews(){
    this.api.getNews().subscribe((res:any)=>{
      this.news = res?.news as News;
      if(this.news.articles.length > 0){
        this.news.articles[0].selected = true;
        this.selectedArticle = this.news.articles[0]
      }
    },
    (err)=>{console.log(err)})
  }

  onSelectArticle(a:Article){
    this.news.articles.map(a=>a.selected = false);
    a.selected = true;
    this.selectedArticle = a;
    window.scroll({ 
      top: 20, 
      left: 0, 
      behavior: 'smooth' 
    });
  }
}
