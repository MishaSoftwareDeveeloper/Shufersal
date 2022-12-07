import { Article } from "./ArticleModel";

export interface News{
    title:string,
    updated:Date,
    articles:Array<Article>
}