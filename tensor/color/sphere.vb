Imports System.math
Imports './color/Green.vb'
Imports './color/Blue.vb'
Imports './color/Red.vb'
Imports './color/anti.vb'
Module XYZT
function SpherePoint
    let X = r * sin(theta) * cos(fai)
    let Y = r * sin(theta) * sin(fai)
    let Z = r * cos(fai).
    let T = r * sin(theta)
    return [X,Y,Z,T]
End Function

Function SphereRadius
    const SphereRadiusx = sin(x) + cos(y) 
    const SphereRadiusy = sin(y) + cos(x) 
    const SphereRadiusz = sin(z) + cos(y)
    return [SphereRadiusx, SphereRadiusy, SphereRadiusz]
End Function
End Module
