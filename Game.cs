<!DOCTYPE html>
<html>
	<head>
		<title>Page Title</title>
		<style>
		    canvas.can2{
		        margin:0;
		        background-image:url('https://b.imge.to/2019/10/08/vFxsV1.png');
		    }
		    body{
		        margin:0;
		    }
		    button{
		        position:absolute;
		        left:0px;
		        padding:10px;
		        background-color:#000000;
		        color:#ffffff;
		        border:0;
		    }
		    button.play{
		        top:400px;
		        font-family:"Old English Text MT";
		        width:160px;
		        font-size:18px;
		    }
		    button.credits{
		        top:450px;
		        font-family:"Old English Text MT";
		        width:150px;
		        font-size:18px;
		    }
		    button.quit{
		        top:500px;
		        font-family:"Old English Text MT";
		        width:140px;
		        font-size:18px;
		    }
		    button.play:hover{
		        top:400px;
		        background-color:#000000;
		        color:#ffffff;
		        font-weight:600;
		        width:190px;
		        font-size:20px;
		        font-family:"Old English Text MT";
		    }
		    button.credits:hover{
		        top:450px;
		        background-color:#000000;
		        color:#ffffff;
		        font-weight:600;
		        font-size:20px;
		        width:180px;
		        font-family:"Old English Text MT";
		    }
		    button.quit:hover{
		        top:500px;
		        background-color:#000000;
		        color:#ffffff;
		        font-weight:600;
		        font-size:20px;
		        width:170px;
		        font-family:"Old English Text MT";
		    }
		    p.heading{
		        text-align:center;
		        font-family:"Old English Text MT";
		        position:absolute;
		        left:30px;
				font-size:80px
		    }
		</style>
	</head>
	<body>
	    <p class="heading">Assasination of  The  Assasin</p>
	    <button class="play">Play</button>
	    <button class="credits">Credits</button>
	    <button class="quit">Quit</button>
	    <canvas id="myCanvas2" class="can2" width="1450px" height="780px"></canvas>
		<script>
		    var canvas2=document.getElementById("myCanvas2");
		    var ctx2=canvas2.getContext("2d");
		    var img1=new Image();
		    var img2=new Image();
		    img1.src='https://a.imge.to/2019/10/07/vFM13F.png';
		    img2.src='https://c.imge.to/2019/10/07/vFMHYV.png';
		    var count=0;
		    var change=0;
		    class forRandom
		    {
		        n;
		        rand()
		        {
		            this.n=Math.ceil(Math.random()*500);
                    if(this.n>=10)
                    {
                        return this.n;
                    }
                    return null;
		        }
		    }
		    var fr=new forRandom();
		    var i1={
		        x:canvas2.width,
		        y:fr.rand(),
		    }
		    var i2={
		        x:canvas2.width,
		        y:fr.rand(),
		    }
		    function anime()
		    {
		        ctx2.clearRect(0,0,canvas2.width,canvas2.height);
		        count++;
		        if(count>=150)
		        {
		            change++;
		            count=0;
		        
		            if(change%2==0)
		            {
		                if(i1.x+150<=0)
		                {   
		                    i1.y=fr.rand();
		                    i1.x=canvas2.width;
		                }
				
		            }
		            else if(change%2==1)
		            {
		                if(i2.x+150<=0)
		                {
		                    i2.y=fr.rand();
		                    i2.x=canvas2.width;
		                }
					}
		        }
		        if(i2.y!=null)
				{
					ctx2.drawImage(img2,i2.x,i2.y);
				}
		        
				if(i1.y!=null)
				{
					ctx2.drawImage(img1,i1.x,i1.y);
				}
		        i1.x-=8;
		        i2.x-=10;
		    }
		    var s=setInterval(anime,10);
		</script>
	</body>
</html>
