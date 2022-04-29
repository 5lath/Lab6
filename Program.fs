open System.Windows.Forms
open System.Drawing
open System


let drawSquare x1 y1 l fillRectangle = //функ. рисует квадрат по левой верх. и правой ниж. точкам
        fillRectangle x1 y1 l

//let drawFractal maxGeneration formXSize =
    //for i = 0 to (maxGeneration-1) do
        //let drawSquare x y l fillRectangle =
            //fillRectangle ((formXSize)/(Math.Pow(2,(float)(i+2)))) ((formXSize)/(Math.Pow(2,(float)(i+2)))) ((formXSize)/(Math.Pow(2,(float)(i+1))))

let drawFractal gen formXSize fillRectangle=
    for i = 0 to 3 do
        drawSquare ((formXSize)/(Math.Pow(2,(float)(gen+1)))) ((formXSize)/(Math.Pow(2,(float)(gen+1)))) ((formXSize)/(Math.Pow(2,(float)(gen)))) fillRectangle =
            fillRectangle ((formXSize)/(Math.Pow(2,(float)(gen+1)))) ((formXSize)/(Math.Pow(2,(float)(gen+1)))) ((formXSize)/(Math.Pow(2,(float)(gen))))


let form =
    let W,H = 800,800

    let temp = new Form()
    temp.BackColor <- Color.LightGreen
    temp.Height <-H
    temp.Width<-W

    let b = new Bitmap(W,H)
    let g = Graphics.FromImage(b)
    let pen = new Pen(Color.Black)
    let brush = new SolidBrush(Color.Blue);
    pen.Width <- (float32)2

    g.FillEllipse(brush,(float32)0,(float32)0,(float32)100,(float32)100)
                    
    drawFractal 3 800 (fun x y l -> g.FillRectangle(brush,(float32)x,(float32)y,(float32)l,(float32)l))
    //drawSquare ((float32)0.25 * (float32)W) ((float32)0.25 * (float32)H) ((float32)0.5 * (float32)W) (fun x y l -> g.FillRectangle(brush,x,y,l,l))
    
    temp.Paint.Add(fun e -> e.Graphics.DrawImage(b, 0, 0))
    temp

[<STAThread>]
do Application.Run(form);;




//let drawSquare x1 y1 l drawLine fillRectangle = //функ. рисует квадрат по левой верх. и правой ниж. точкам
    //drawLine x1 y1 (x1+l) y1//верх-я линия
    //drawLine (x1+l) y1 (x1+l) (y1+l)//правая линия
    //drawLine (x1+l) (y1+l) x1 (y1+l)//нижняя линия
    //drawLine x1 (y1+l) x1 y1//лев-я линия
    //fillRectangle x1 y1 l
//drawSquare ((float32)0.25 * (float32)W) ((float32)0.25 * (float32)H) ((float32)0.5 * (float32)W) (fun x y x1 y1 -> Graphics.FromImage(b).DrawLine( pen, (float32)x, (float32)(y), (float32)x1, (float32) (y1))) (fun x y l -> g.FillRectangle(brush,x,y,l,l))


//drawSquare ((formXSize)/(Math.Pow(2,(float)(i+2)))) ((formXSize)/(Math.Pow(2,(float)(i+2)))) ((formXSize)/(Math.Pow(2,(float)(i+1)))) fillRectangle =
   //fillRectangle ((formXSize)/(Math.Pow(2,(float)(i+2)))) ((formXSize)/(Math.Pow(2,(float)(i+2)))) ((formXSize)/(Math.Pow(2,(float)(i+1))))

   //let drawFractal gen formXSize fillRectangle=
    //for i = 0 to (gen-1) do
        //drawSquare ((formXSize)/(Math.Pow(2,(float)(gen+2)))) ((formXSize)/(Math.Pow(2,(float)(gen+2)))) ((formXSize)/(Math.Pow(2,(float)(gen+1)))) fillRectangle =
            //fillRectangle ((formXSize)/(Math.Pow(2,(float)(gen+2)))) ((formXSize)/(Math.Pow(2,(float)(gen+2)))) ((formXSize)/(Math.Pow(2,(float)(gen+1))))