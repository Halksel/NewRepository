#include<stdio.h>

//Args
int sig;
void (*func)(int);
void (*signal(int sig, void (*func(int))))(int hoge);
// 関数の部分適用？
// int と intを受け取りvoidを返す関数へのポインタを受け取る関数にintを部分適用した戻り値がvoid
// int と intを受け取りvoidを返す関数へのポインタがintを受け取り、voidを返すsignalという関数である
void (*signal(Args))(int)
int main(){
  printf("%p\n",func); 
  printf("%p\n",signal); 
}
