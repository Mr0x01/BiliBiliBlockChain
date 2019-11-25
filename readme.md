# BiliBili批量拉黑工具
BiliBili批量拉黑工具
~~还你一片净土。~~ 
![Report。txt](https://raw.githubusercontent.com/Mr0x01/BiliBiliBlockChain/master/BiliBiliBlockChain/Sample/2.png "Report。txt")
# 放在开始
## 1. 黑名单存在上限

       黑名单数=500+int（粉丝数/10000）*20，其中上限不超过5000

举例来说，
    一般用户没有粉丝，则黑名单容量为500。
一个用户有10000个粉丝，根据公式500+(10000/10000)*20=520(人)。也就是说，最少你能拉黑500人，最多也只能5000人。所以你没法获得完全安静的世界(Sad)。

## 2. 获取某用户的关注者存在限制

B站官方限制了只能获取前5页的关注者，经过测试每页最多50人，也就是单次拉黑最多250人。

## 3. 如何获得用户ID

比如我想拉黑关注了A的人，那么仅需打开A的个人空间页，比如
> https://space.bilibili.com/9999999

那么9999999就是A的用户ID。(随手写的，并没有针对9999999这位朋友。)

## 4. 额……

上述的限制也是在测试过后才知道的。。。。这也就造成了这个工具失去了实际的意义。那就当个乐吧~~好歹能拉黑500个~~。

# 使用说明

1. 登录

    点击“登录”按钮后，在弹出的窗口里输入用户名、密码并完成拖动验证后即可正常使用。

2. 拉黑

    在右侧文本框里输入用户ID，即可将其关注者拉黑。
    
# 碰碰运气

如果这个项目帮到了你，或者感觉有点儿意思，可以的话还请支持一下。
<figure class="half">
<img src="https://raw.githubusercontent.com/Mr0x01/MoneyCode/master/a.jpg" height="300"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://raw.githubusercontent.com/Mr0x01/MoneyCode/master/w.jpg"height="300" />
</figure>

