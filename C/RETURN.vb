Structure RETUrN
   char R,E,T,U,r,N;
   char a,b,c,d,e,f;
Sub R
    int t1,t2
   return t1 * sin(R + a) + t2 * cos(R - b)
   return t1 * cos(R + a) + t2 * sin(R - b)
End Sub
Sub E
     int t3,t4
   return t3 * asin(E + b) + t4 * acos(E - c)
   return t3 * acos(E + b) + t4 * asin(E - c)
End Sub
Sub T
     int t5,t6
   return t5 * tan(T + c) + t6 * atan(T - d) 
   return t5 * atan(T + c) + t6 * tan(T - d)  
End Sub
Sub U
     int t7,t8
   return t7 * sinh(U + d) + t8 * cosh(U - d)
   return t7 * cosh(U + e) + t8 * sinh(U - e)
End Sub   
Sub r
      int t9,t10
   return t9 * ceil(r + e) + t10 * floor(r - e)
   return t9 * ceil(r + f) + t10 * floor(r - f)
End Sub
Sub N
    int t11,t0 
   return t11 * exp(N + f) + t0 * log(N - f)
   return t11 * exp(N + a) + t0 * log(N - a)
End Sub
End Structure
int RETURN(a,b,c,d,e,f)
    const R = "a + b + c + d + e + f"
    const E = "a - b - c - d - e - f"
    const T = "a * b * c * d * e * f"
    const U = "a / b / c / d / e / f"
    const R = "a % b % c % d % e % f"
    const N = "a ::b ::c ::d ::e ::f"
