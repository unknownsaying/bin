Sub x2y2z2t2
Function x2
    for (let i = 0; i <= 6; i++)
        for (let j = 0; j <= 6; j++)
            for (let k = 0; k <= 6; k++)
        continue
End Function
Function y2
    for (let l = 0; l >= -6 || l <= 6; ++l || l--)
        for (let m = 0; m >= -6 && m <= 6; ++m || m--)
            for (let n = 0; n >= -6 && n <= 6; ++n || n--)
        break
End Function
Function z2
    for (let o = 0; o >= 6; --o)
        for (let p = 0; p >= 6; --p)
            for (let q = 0; q >= 6; --q)
        continue
End Function
Function t2
    do `y2*z2`
    while (
        z2: `0,x<=2,z++`
    )
    do `x2*z2`
    while (
        y2: `0,y<=2,y++`
    )
    do `x2*y2`
    while (
        x2: `0,z<=2,x++`
    )
End Function
End Sub
