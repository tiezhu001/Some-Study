
// 字符串嵌入表达式
var a = 10;
var b = 20;
console.log(`Result is ${a+b}`);

// 正则表达式之断言

var testStr = "aab4bd3efhijk--6";

// 先前断言 是括号内的不匹配但是,匹配的字符串从括号前的字符开始匹配
var re1 = /\w+4(?=b)\w+\d/;
var result1 = re1.exec(testStr);
console.log(result1);

// 负向先行断言 / /里边写的正则,前后不能留有空格
var re2 = /\w+4(?!5)\w+\d\w+/
var result2 = re2.exec(testStr);
console.log(result2);

//后行断言
