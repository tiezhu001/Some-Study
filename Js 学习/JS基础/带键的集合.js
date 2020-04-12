
// 1.Map对象 map对象中的内容是有顺序的

// 创建

//可以直接往Map的构造函数添加数组,但是这个数组必须是一个键值对
var array1 = [["key3","value3"]];
var map1 = new Map([["key1",1],["key2",2]]);
var map2 = new Map(array1);
for(let [key,value] of map1){
        console.log(key+":"+value);
}
for(let [key,value] of map2){
    console.log(key+":"+value);
}

// Map对象的属性
console.log("map对象的属性");
console.log(map1.size);
console.log(map1.constructor);

// 清楚所有的键值对值
map2.clear();
for(let [key,value] of map2){
    console.log(key+":"+value);
}

// 删除指定键的元素
map1.delete("key1");
for(let [key,value] of map1){
    console.log(key+":"+value);
}

console.log("返回一个迭代器对象");
var array2 = [["key1",1],["key2",2],["key3",3]];
var map3 = new Map(array2);

var iterator1 = map3.entries();
console.log(iterator1.next().value); // 返回第一个键值对数组
console.log(iterator1.next().value); // 返回第二个键值对数组

// foreach方法
console.log("foreach");
var map4 = new Map();
function mapss(value,key,map){
    console.log(key+":"+value);
}
map3.forEach(mapss);

console.log('通过键访问值');
// 通过键访问值

console.log(map3.get("key1"));

console.log('判断map对象是否存在某个键');

console.log(map3.has('key11'));  // false 

console.log('获取map对象的所有键');
var keysIterator = map3.keys();
console.log(keysIterator.next().value);

console.log("set给map对象添加键值对");
map3.set("key4",4);
for(let [key,value] of map3){
    console.log(key+":"+value);
}



console.log("----------------------------------");

// 2.set集合,是一组值的集合，这些值是不可重复的。

let set1 = new Set([1,2,3,4,5,'str',false,[1,2,3,4]]);
set1.forEach((value)=>{console.log(value);})

// 增加 add 向集合的尾部添加元素
console.log('添加元素之后');
set1.add("hasaki");
set1.forEach((value)=>{console.log(value);})

console.log('清除所有集合中的元素');
// set1.clear();

console.log("删除指定的值");
// var deleteFlag = set1.delete(1);
// console.log(deleteFlag);

console.log('返回一个新的迭代器对象');
var canDieDai = set1.entries();
console.log(canDieDai.next().value); //返回一个键值对数组 [2,2] 值和键是相等的。

console.log("has判断是否是指定的值");
console.log(set1.has(66));

console.log("values()获取所有的值");
var canDiedai2 = set1.values();
console.log(canDiedai2.next().value);

// 迭代set

console.log('for of迭代');

for(let value of set1){
    console.log(value);
}

//Array相关
console.log("array相关");
let array3 = new Array("abc","abc","cde","fgh");

let set2 = new Set(array3);  //可以把一个数组对象传递给Set的构造器,且可以实现数组去重

for(let value of set2){
    console.log(value);
}

// String相关
console.log("string相关");
let str1 = "abcde";

let set3 = new Set(str1);  //如果把一个String对象传递给Set构造器.将把字符串的每一个字符拆开成为set的每一个值

for(let value of set3){
    console.log(value);
}