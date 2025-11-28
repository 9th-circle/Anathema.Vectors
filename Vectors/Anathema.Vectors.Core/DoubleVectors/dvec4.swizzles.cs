#if DOUBLES_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dvec4
    {

#if CAPITALS_ENABLED
        public double W
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }
#endif
        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)
#if SWIZZLES_ENABLED
        public dvec4 xyzw
        {
            get
            {
                return new dvec4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public dvec4 xwzy
        {
            get
            {
                return new dvec4(x, w, z, y);
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public dvec4 xwyz
        {
            get
            {
                return new dvec4(x, w, y, z);
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        public dvec4 xywz
        {
            get
            {
                return new dvec4(x, y, w, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public dvec4 xzyw
        {
            get
            {
                return new dvec4(x, z, y, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public dvec4 xzwy
        {
            get
            {
                return new dvec4(x, z, w, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }





        //Starting with Y (6)

        public dvec4 yxzw
        {
            get
            {
                return new dvec4(y, x, z, w);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public dvec4 yxwz
        {
            get
            {
                return new dvec4(y, x, w, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public dvec4 yzxw
        {
            get
            {
                return new dvec4(y, z, x, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public dvec4 yzwx
        {
            get
            {
                return new dvec4(y, z, w, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public dvec4 ywzx
        {
            get
            {
                return new dvec4(y, w, z, x);
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public dvec4 ywxz
        {
            get
            {
                return new dvec4(y, w, x, z);
            }
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }



        //Starting with Z (6)

        public dvec4 zxyw
        {
            get
            {
                return new dvec4(z, x, y, w);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public dvec4 zyxw
        {
            get
            {
                return new dvec4(z, y, x, w);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public dvec4 zywx
        {
            get
            {
                return new dvec4(z, y, w, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public dvec4 zxwy
        {
            get
            {
                return new dvec4(z, x, w, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        public dvec4 zwxy
        {
            get
            {
                return new dvec4(z, w, x, y);
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public dvec4 zwyx
        {
            get
            {
                return new dvec4(z, w, y, x);
            }
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }



        //Starting with W (6)

        public dvec4 wxyz
        {
            get
            {
                return new dvec4(w, x, y, z);
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        public dvec4 wxzy
        {
            get
            {
                return new dvec4(w, x, z, y);
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public dvec4 wyxz
        {
            get
            {
                return new dvec4(w, y, x, z);
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        public dvec4 wyzx
        {
            get
            {
                return new dvec4(w, y, z, x);
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public dvec4 wzxy
        {
            get
            {
                return new dvec4(w, z, x, y);
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public dvec4 wzyx
        {
            get
            {
                return new dvec4(w, z, y, x);
            }
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }
#if SWIZZLE_DUPLICATES_ENABLED
        // vec2 duplicate
        public dvec2 ww
        {
            get { return new dvec2(w, w); }
            set { w = value.x; w = value.y; }
        }

        // dvec4 duplicates
        public dvec4 xxxx { get { return new dvec4(x, x, x, x); } set { x = value.x; x = value.y; x = value.z; x = value.w; } }
        public dvec4 xxxy { get { return new dvec4(x, x, x, y); } set { x = value.x; x = value.y; x = value.z; y = value.w; } }
        public dvec4 xxxz { get { return new dvec4(x, x, x, z); } set { x = value.x; x = value.y; x = value.z; z = value.w; } }
        public dvec4 xxxw { get { return new dvec4(x, x, x, w); } set { x = value.x; x = value.y; x = value.z; w = value.w; } }
        public dvec4 xxyx { get { return new dvec4(x, x, y, x); } set { x = value.x; x = value.y; y = value.z; x = value.w; } }
        public dvec4 xxyy { get { return new dvec4(x, x, y, y); } set { x = value.x; x = value.y; y = value.z; y = value.w; } }
        public dvec4 xxyz { get { return new dvec4(x, x, y, z); } set { x = value.x; x = value.y; y = value.z; z = value.w; } }
        public dvec4 xxyw { get { return new dvec4(x, x, y, w); } set { x = value.x; x = value.y; y = value.z; w = value.w; } }
        public dvec4 xxzx { get { return new dvec4(x, x, z, x); } set { x = value.x; x = value.y; z = value.z; x = value.w; } }
        public dvec4 xxzy { get { return new dvec4(x, x, z, y); } set { x = value.x; x = value.y; z = value.z; y = value.w; } }
        public dvec4 xxzz { get { return new dvec4(x, x, z, z); } set { x = value.x; x = value.y; z = value.z; z = value.w; } }
        public dvec4 xxzw { get { return new dvec4(x, x, z, w); } set { x = value.x; x = value.y; z = value.z; w = value.w; } }
        public dvec4 xxwx { get { return new dvec4(x, x, w, x); } set { x = value.x; x = value.y; w = value.z; x = value.w; } }
        public dvec4 xxwy { get { return new dvec4(x, x, w, y); } set { x = value.x; x = value.y; w = value.z; y = value.w; } }
        public dvec4 xxwz { get { return new dvec4(x, x, w, z); } set { x = value.x; x = value.y; w = value.z; z = value.w; } }
        public dvec4 xxww { get { return new dvec4(x, x, w, w); } set { x = value.x; x = value.y; w = value.z; w = value.w; } }
        public dvec4 xyxx { get { return new dvec4(x, y, x, x); } set { x = value.x; y = value.y; x = value.z; x = value.w; } }
        public dvec4 xyxy { get { return new dvec4(x, y, x, y); } set { x = value.x; y = value.y; x = value.z; y = value.w; } }
        public dvec4 xyxz { get { return new dvec4(x, y, x, z); } set { x = value.x; y = value.y; x = value.z; z = value.w; } }
        public dvec4 xyxw { get { return new dvec4(x, y, x, w); } set { x = value.x; y = value.y; x = value.z; w = value.w; } }
        public dvec4 xyyx { get { return new dvec4(x, y, y, x); } set { x = value.x; y = value.y; y = value.z; x = value.w; } }
        public dvec4 xyyy { get { return new dvec4(x, y, y, y); } set { x = value.x; y = value.y; y = value.z; y = value.w; } }
        public dvec4 xyyz { get { return new dvec4(x, y, y, z); } set { x = value.x; y = value.y; y = value.z; z = value.w; } }
        public dvec4 xyyw { get { return new dvec4(x, y, y, w); } set { x = value.x; y = value.y; y = value.z; w = value.w; } }
        public dvec4 xyzx { get { return new dvec4(x, y, z, x); } set { x = value.x; y = value.y; z = value.z; x = value.w; } }
        public dvec4 xyzy { get { return new dvec4(x, y, z, y); } set { x = value.x; y = value.y; z = value.z; y = value.w; } }
        public dvec4 xyzz { get { return new dvec4(x, y, z, z); } set { x = value.x; y = value.y; z = value.z; z = value.w; } }
        public dvec4 xywx { get { return new dvec4(x, y, w, x); } set { x = value.x; y = value.y; w = value.z; x = value.w; } }
        public dvec4 xywy { get { return new dvec4(x, y, w, y); } set { x = value.x; y = value.y; w = value.z; y = value.w; } }
        public dvec4 xyww { get { return new dvec4(x, y, w, w); } set { x = value.x; y = value.y; w = value.z; w = value.w; } }
        public dvec4 xzxx { get { return new dvec4(x, z, x, x); } set { x = value.x; z = value.y; x = value.z; x = value.w; } }
        public dvec4 xzxy { get { return new dvec4(x, z, x, y); } set { x = value.x; z = value.y; x = value.z; y = value.w; } }
        public dvec4 xzxz { get { return new dvec4(x, z, x, z); } set { x = value.x; z = value.y; x = value.z; z = value.w; } }
        public dvec4 xzxw { get { return new dvec4(x, z, x, w); } set { x = value.x; z = value.y; x = value.z; w = value.w; } }
        public dvec4 xzyx { get { return new dvec4(x, z, y, x); } set { x = value.x; z = value.y; y = value.z; x = value.w; } }
        public dvec4 xzyy { get { return new dvec4(x, z, y, y); } set { x = value.x; z = value.y; y = value.z; y = value.w; } }
        public dvec4 xzyz { get { return new dvec4(x, z, y, z); } set { x = value.x; z = value.y; y = value.z; z = value.w; } }
        public dvec4 xzzx { get { return new dvec4(x, z, z, x); } set { x = value.x; z = value.y; z = value.z; x = value.w; } }
        public dvec4 xzzy { get { return new dvec4(x, z, z, y); } set { x = value.x; z = value.y; z = value.z; y = value.w; } }
        public dvec4 xzzz { get { return new dvec4(x, z, z, z); } set { x = value.x; z = value.y; z = value.z; z = value.w; } }
        public dvec4 xzzw { get { return new dvec4(x, z, z, w); } set { x = value.x; z = value.y; z = value.z; w = value.w; } }
        public dvec4 xzwx { get { return new dvec4(x, z, w, x); } set { x = value.x; z = value.y; w = value.z; x = value.w; } }
        public dvec4 xzwz { get { return new dvec4(x, z, w, z); } set { x = value.x; z = value.y; w = value.z; z = value.w; } }
        public dvec4 xzww { get { return new dvec4(x, z, w, w); } set { x = value.x; z = value.y; w = value.z; w = value.w; } }
        public dvec4 xwxx { get { return new dvec4(x, w, x, x); } set { x = value.x; w = value.y; x = value.z; x = value.w; } }
        public dvec4 xwxy { get { return new dvec4(x, w, x, y); } set { x = value.x; w = value.y; x = value.z; y = value.w; } }
        public dvec4 xwxz { get { return new dvec4(x, w, x, z); } set { x = value.x; w = value.y; x = value.z; z = value.w; } }
        public dvec4 xwxw { get { return new dvec4(x, w, x, w); } set { x = value.x; w = value.y; x = value.z; w = value.w; } }
        public dvec4 xwyx { get { return new dvec4(x, w, y, x); } set { x = value.x; w = value.y; y = value.z; x = value.w; } }
        public dvec4 xwyy { get { return new dvec4(x, w, y, y); } set { x = value.x; w = value.y; y = value.z; y = value.w; } }
        public dvec4 xwyw { get { return new dvec4(x, w, y, w); } set { x = value.x; w = value.y; y = value.z; w = value.w; } }
        public dvec4 xwzx { get { return new dvec4(x, w, z, x); } set { x = value.x; w = value.y; z = value.z; x = value.w; } }
        public dvec4 xwzz { get { return new dvec4(x, w, z, z); } set { x = value.x; w = value.y; z = value.z; z = value.w; } }
        public dvec4 xwzw { get { return new dvec4(x, w, z, w); } set { x = value.x; w = value.y; z = value.z; w = value.w; } }
        public dvec4 xwwx { get { return new dvec4(x, w, w, x); } set { x = value.x; w = value.y; w = value.z; x = value.w; } }
        public dvec4 xwwy { get { return new dvec4(x, w, w, y); } set { x = value.x; w = value.y; w = value.z; y = value.w; } }
        public dvec4 xwwz { get { return new dvec4(x, w, w, z); } set { x = value.x; w = value.y; w = value.z; z = value.w; } }
        public dvec4 xwww { get { return new dvec4(x, w, w, w); } set { x = value.x; w = value.y; w = value.z; w = value.w; } }
        public dvec4 yxxx { get { return new dvec4(y, x, x, x); } set { y = value.x; x = value.y; x = value.z; x = value.w; } }
        public dvec4 yxxy { get { return new dvec4(y, x, x, y); } set { y = value.x; x = value.y; x = value.z; y = value.w; } }
        public dvec4 yxxz { get { return new dvec4(y, x, x, z); } set { y = value.x; x = value.y; x = value.z; z = value.w; } }
        public dvec4 yxxw { get { return new dvec4(y, x, x, w); } set { y = value.x; x = value.y; x = value.z; w = value.w; } }
        public dvec4 yxyx { get { return new dvec4(y, x, y, x); } set { y = value.x; x = value.y; y = value.z; x = value.w; } }
        public dvec4 yxyy { get { return new dvec4(y, x, y, y); } set { y = value.x; x = value.y; y = value.z; y = value.w; } }
        public dvec4 yxyz { get { return new dvec4(y, x, y, z); } set { y = value.x; x = value.y; y = value.z; z = value.w; } }
        public dvec4 yxyw { get { return new dvec4(y, x, y, w); } set { y = value.x; x = value.y; y = value.z; w = value.w; } }
        public dvec4 yxzx { get { return new dvec4(y, x, z, x); } set { y = value.x; x = value.y; z = value.z; x = value.w; } }
        public dvec4 yxzy { get { return new dvec4(y, x, z, y); } set { y = value.x; x = value.y; z = value.z; y = value.w; } }
        public dvec4 yxzz { get { return new dvec4(y, x, z, z); } set { y = value.x; x = value.y; z = value.z; z = value.w; } }
        public dvec4 yxwx { get { return new dvec4(y, x, w, x); } set { y = value.x; x = value.y; w = value.z; x = value.w; } }
        public dvec4 yxwy { get { return new dvec4(y, x, w, y); } set { y = value.x; x = value.y; w = value.z; y = value.w; } }
        public dvec4 yxww { get { return new dvec4(y, x, w, w); } set { y = value.x; x = value.y; w = value.z; w = value.w; } }
        public dvec4 yyxx { get { return new dvec4(y, y, x, x); } set { y = value.x; y = value.y; x = value.z; x = value.w; } }
        public dvec4 yyxy { get { return new dvec4(y, y, x, y); } set { y = value.x; y = value.y; x = value.z; y = value.w; } }
        public dvec4 yyxz { get { return new dvec4(y, y, x, z); } set { y = value.x; y = value.y; x = value.z; z = value.w; } }
        public dvec4 yyxw { get { return new dvec4(y, y, x, w); } set { y = value.x; y = value.y; x = value.z; w = value.w; } }
        public dvec4 yyyx { get { return new dvec4(y, y, y, x); } set { y = value.x; y = value.y; y = value.z; x = value.w; } }
        public dvec4 yyyy { get { return new dvec4(y, y, y, y); } set { y = value.x; y = value.y; y = value.z; y = value.w; } }
        public dvec4 yyyz { get { return new dvec4(y, y, y, z); } set { y = value.x; y = value.y; y = value.z; z = value.w; } }
        public dvec4 yyyw { get { return new dvec4(y, y, y, w); } set { y = value.x; y = value.y; y = value.z; w = value.w; } }
        public dvec4 yyzx { get { return new dvec4(y, y, z, x); } set { y = value.x; y = value.y; z = value.z; x = value.w; } }
        public dvec4 yyzy { get { return new dvec4(y, y, z, y); } set { y = value.x; y = value.y; z = value.z; y = value.w; } }
        public dvec4 yyzz { get { return new dvec4(y, y, z, z); } set { y = value.x; y = value.y; z = value.z; z = value.w; } }
        public dvec4 yyzw { get { return new dvec4(y, y, z, w); } set { y = value.x; y = value.y; z = value.z; w = value.w; } }
        public dvec4 yywx { get { return new dvec4(y, y, w, x); } set { y = value.x; y = value.y; w = value.z; x = value.w; } }
        public dvec4 yywy { get { return new dvec4(y, y, w, y); } set { y = value.x; y = value.y; w = value.z; y = value.w; } }
        public dvec4 yywz { get { return new dvec4(y, y, w, z); } set { y = value.x; y = value.y; w = value.z; z = value.w; } }
        public dvec4 yyww { get { return new dvec4(y, y, w, w); } set { y = value.x; y = value.y; w = value.z; w = value.w; } }
        public dvec4 yzxx { get { return new dvec4(y, z, x, x); } set { y = value.x; z = value.y; x = value.z; x = value.w; } }
        public dvec4 yzxy { get { return new dvec4(y, z, x, y); } set { y = value.x; z = value.y; x = value.z; y = value.w; } }
        public dvec4 yzxz { get { return new dvec4(y, z, x, z); } set { y = value.x; z = value.y; x = value.z; z = value.w; } }
        public dvec4 yzyx { get { return new dvec4(y, z, y, x); } set { y = value.x; z = value.y; y = value.z; x = value.w; } }
        public dvec4 yzyy { get { return new dvec4(y, z, y, y); } set { y = value.x; z = value.y; y = value.z; y = value.w; } }
        public dvec4 yzyz { get { return new dvec4(y, z, y, z); } set { y = value.x; z = value.y; y = value.z; z = value.w; } }
        public dvec4 yzyw { get { return new dvec4(y, z, y, w); } set { y = value.x; z = value.y; y = value.z; w = value.w; } }
        public dvec4 yzzx { get { return new dvec4(y, z, z, x); } set { y = value.x; z = value.y; z = value.z; x = value.w; } }
        public dvec4 yzzy { get { return new dvec4(y, z, z, y); } set { y = value.x; z = value.y; z = value.z; y = value.w; } }
        public dvec4 yzzz { get { return new dvec4(y, z, z, z); } set { y = value.x; z = value.y; z = value.z; z = value.w; } }
        public dvec4 yzzw { get { return new dvec4(y, z, z, w); } set { y = value.x; z = value.y; z = value.z; w = value.w; } }
        public dvec4 yzwy { get { return new dvec4(y, z, w, y); } set { y = value.x; z = value.y; w = value.z; y = value.w; } }
        public dvec4 yzwz { get { return new dvec4(y, z, w, z); } set { y = value.x; z = value.y; w = value.z; z = value.w; } }
        public dvec4 yzww { get { return new dvec4(y, z, w, w); } set { y = value.x; z = value.y; w = value.z; w = value.w; } }
        public dvec4 ywxx { get { return new dvec4(y, w, x, x); } set { y = value.x; w = value.y; x = value.z; x = value.w; } }
        public dvec4 ywxy { get { return new dvec4(y, w, x, y); } set { y = value.x; w = value.y; x = value.z; y = value.w; } }
        public dvec4 ywxw { get { return new dvec4(y, w, x, w); } set { y = value.x; w = value.y; x = value.z; w = value.w; } }
        public dvec4 ywyx { get { return new dvec4(y, w, y, x); } set { y = value.x; w = value.y; y = value.z; x = value.w; } }
        public dvec4 ywyy { get { return new dvec4(y, w, y, y); } set { y = value.x; w = value.y; y = value.z; y = value.w; } }
        public dvec4 ywyz { get { return new dvec4(y, w, y, z); } set { y = value.x; w = value.y; y = value.z; z = value.w; } }
        public dvec4 ywyw { get { return new dvec4(y, w, y, w); } set { y = value.x; w = value.y; y = value.z; w = value.w; } }
        public dvec4 ywzy { get { return new dvec4(y, w, z, y); } set { y = value.x; w = value.y; z = value.z; y = value.w; } }
        public dvec4 ywzz { get { return new dvec4(y, w, z, z); } set { y = value.x; w = value.y; z = value.z; z = value.w; } }
        public dvec4 ywzw { get { return new dvec4(y, w, z, w); } set { y = value.x; w = value.y; z = value.z; w = value.w; } }
        public dvec4 ywwx { get { return new dvec4(y, w, w, x); } set { y = value.x; w = value.y; w = value.z; x = value.w; } }
        public dvec4 ywwy { get { return new dvec4(y, w, w, y); } set { y = value.x; w = value.y; w = value.z; y = value.w; } }
        public dvec4 ywwz { get { return new dvec4(y, w, w, z); } set { y = value.x; w = value.y; w = value.z; z = value.w; } }
        public dvec4 ywww { get { return new dvec4(y, w, w, w); } set { y = value.x; w = value.y; w = value.z; w = value.w; } }
        public dvec4 zxxx { get { return new dvec4(z, x, x, x); } set { z = value.x; x = value.y; x = value.z; x = value.w; } }
        public dvec4 zxxy { get { return new dvec4(z, x, x, y); } set { z = value.x; x = value.y; x = value.z; y = value.w; } }
        public dvec4 zxxz { get { return new dvec4(z, x, x, z); } set { z = value.x; x = value.y; x = value.z; z = value.w; } }
        public dvec4 zxxw { get { return new dvec4(z, x, x, w); } set { z = value.x; x = value.y; x = value.z; w = value.w; } }
        public dvec4 zxyx { get { return new dvec4(z, x, y, x); } set { z = value.x; x = value.y; y = value.z; x = value.w; } }
        public dvec4 zxyy { get { return new dvec4(z, x, y, y); } set { z = value.x; x = value.y; y = value.z; y = value.w; } }
        public dvec4 zxyz { get { return new dvec4(z, x, y, z); } set { z = value.x; x = value.y; y = value.z; z = value.w; } }
        public dvec4 zxzx { get { return new dvec4(z, x, z, x); } set { z = value.x; x = value.y; z = value.z; x = value.w; } }
        public dvec4 zxzy { get { return new dvec4(z, x, z, y); } set { z = value.x; x = value.y; z = value.z; y = value.w; } }
        public dvec4 zxzz { get { return new dvec4(z, x, z, z); } set { z = value.x; x = value.y; z = value.z; z = value.w; } }
        public dvec4 zxzw { get { return new dvec4(z, x, z, w); } set { z = value.x; x = value.y; z = value.z; w = value.w; } }
        public dvec4 zxwx { get { return new dvec4(z, x, w, x); } set { z = value.x; x = value.y; w = value.z; x = value.w; } }
        public dvec4 zxwz { get { return new dvec4(z, x, w, z); } set { z = value.x; x = value.y; w = value.z; z = value.w; } }
        public dvec4 zxww { get { return new dvec4(z, x, w, w); } set { z = value.x; x = value.y; w = value.z; w = value.w; } }
        public dvec4 zyxx { get { return new dvec4(z, y, x, x); } set { z = value.x; y = value.y; x = value.z; x = value.w; } }
        public dvec4 zyxy { get { return new dvec4(z, y, x, y); } set { z = value.x; y = value.y; x = value.z; y = value.w; } }
        public dvec4 zyxz { get { return new dvec4(z, y, x, z); } set { z = value.x; y = value.y; x = value.z; z = value.w; } }
        public dvec4 zyyx { get { return new dvec4(z, y, y, x); } set { z = value.x; y = value.y; y = value.z; x = value.w; } }
        public dvec4 zyyy { get { return new dvec4(z, y, y, y); } set { z = value.x; y = value.y; y = value.z; y = value.w; } }
        public dvec4 zyyz { get { return new dvec4(z, y, y, z); } set { z = value.x; y = value.y; y = value.z; z = value.w; } }
        public dvec4 zyyw { get { return new dvec4(z, y, y, w); } set { z = value.x; y = value.y; y = value.z; w = value.w; } }
        public dvec4 zyzx { get { return new dvec4(z, y, z, x); } set { z = value.x; y = value.y; z = value.z; x = value.w; } }
        public dvec4 zyzy { get { return new dvec4(z, y, z, y); } set { z = value.x; y = value.y; z = value.z; y = value.w; } }
        public dvec4 zyzz { get { return new dvec4(z, y, z, z); } set { z = value.x; y = value.y; z = value.z; z = value.w; } }
        public dvec4 zyzw { get { return new dvec4(z, y, z, w); } set { z = value.x; y = value.y; z = value.z; w = value.w; } }
        public dvec4 zywy { get { return new dvec4(z, y, w, y); } set { z = value.x; y = value.y; w = value.z; y = value.w; } }
        public dvec4 zywz { get { return new dvec4(z, y, w, z); } set { z = value.x; y = value.y; w = value.z; z = value.w; } }
        public dvec4 zyww { get { return new dvec4(z, y, w, w); } set { z = value.x; y = value.y; w = value.z; w = value.w; } }
        public dvec4 zzxx { get { return new dvec4(z, z, x, x); } set { z = value.x; z = value.y; x = value.z; x = value.w; } }
        public dvec4 zzxy { get { return new dvec4(z, z, x, y); } set { z = value.x; z = value.y; x = value.z; y = value.w; } }
        public dvec4 zzxz { get { return new dvec4(z, z, x, z); } set { z = value.x; z = value.y; x = value.z; z = value.w; } }
        public dvec4 zzxw { get { return new dvec4(z, z, x, w); } set { z = value.x; z = value.y; x = value.z; w = value.w; } }
        public dvec4 zzyx { get { return new dvec4(z, z, y, x); } set { z = value.x; z = value.y; y = value.z; x = value.w; } }
        public dvec4 zzyy { get { return new dvec4(z, z, y, y); } set { z = value.x; z = value.y; y = value.z; y = value.w; } }
        public dvec4 zzyz { get { return new dvec4(z, z, y, z); } set { z = value.x; z = value.y; y = value.z; z = value.w; } }
        public dvec4 zzyw { get { return new dvec4(z, z, y, w); } set { z = value.x; z = value.y; y = value.z; w = value.w; } }
        public dvec4 zzzx { get { return new dvec4(z, z, z, x); } set { z = value.x; z = value.y; z = value.z; x = value.w; } }
        public dvec4 zzzy { get { return new dvec4(z, z, z, y); } set { z = value.x; z = value.y; z = value.z; y = value.w; } }
        public dvec4 zzzz { get { return new dvec4(z, z, z, z); } set { z = value.x; z = value.y; z = value.z; z = value.w; } }
        public dvec4 zzzw { get { return new dvec4(z, z, z, w); } set { z = value.x; z = value.y; z = value.z; w = value.w; } }
        public dvec4 zzwx { get { return new dvec4(z, z, w, x); } set { z = value.x; z = value.y; w = value.z; x = value.w; } }
        public dvec4 zzwy { get { return new dvec4(z, z, w, y); } set { z = value.x; z = value.y; w = value.z; y = value.w; } }
        public dvec4 zzwz { get { return new dvec4(z, z, w, z); } set { z = value.x; z = value.y; w = value.z; z = value.w; } }
        public dvec4 zzww { get { return new dvec4(z, z, w, w); } set { z = value.x; z = value.y; w = value.z; w = value.w; } }
        public dvec4 zwxx { get { return new dvec4(z, w, x, x); } set { z = value.x; w = value.y; x = value.z; x = value.w; } }
        public dvec4 zwxz { get { return new dvec4(z, w, x, z); } set { z = value.x; w = value.y; x = value.z; z = value.w; } }
        public dvec4 zwxw { get { return new dvec4(z, w, x, w); } set { z = value.x; w = value.y; x = value.z; w = value.w; } }
        public dvec4 zwyy { get { return new dvec4(z, w, y, y); } set { z = value.x; w = value.y; y = value.z; y = value.w; } }
        public dvec4 zwyz { get { return new dvec4(z, w, y, z); } set { z = value.x; w = value.y; y = value.z; z = value.w; } }
        public dvec4 zwyw { get { return new dvec4(z, w, y, w); } set { z = value.x; w = value.y; y = value.z; w = value.w; } }
        public dvec4 zwzx { get { return new dvec4(z, w, z, x); } set { z = value.x; w = value.y; z = value.z; x = value.w; } }
        public dvec4 zwzy { get { return new dvec4(z, w, z, y); } set { z = value.x; w = value.y; z = value.z; y = value.w; } }
        public dvec4 zwzz { get { return new dvec4(z, w, z, z); } set { z = value.x; w = value.y; z = value.z; z = value.w; } }
        public dvec4 zwzw { get { return new dvec4(z, w, z, w); } set { z = value.x; w = value.y; z = value.z; w = value.w; } }
        public dvec4 zwwx { get { return new dvec4(z, w, w, x); } set { z = value.x; w = value.y; w = value.z; x = value.w; } }
        public dvec4 zwwy { get { return new dvec4(z, w, w, y); } set { z = value.x; w = value.y; w = value.z; y = value.w; } }
        public dvec4 zwwz { get { return new dvec4(z, w, w, z); } set { z = value.x; w = value.y; w = value.z; z = value.w; } }
        public dvec4 zwww { get { return new dvec4(z, w, w, w); } set { z = value.x; w = value.y; w = value.z; w = value.w; } }
        public dvec4 wxxx { get { return new dvec4(w, x, x, x); } set { w = value.x; x = value.y; x = value.z; x = value.w; } }
        public dvec4 wxxy { get { return new dvec4(w, x, x, y); } set { w = value.x; x = value.y; x = value.z; y = value.w; } }
        public dvec4 wxxz { get { return new dvec4(w, x, x, z); } set { w = value.x; x = value.y; x = value.z; z = value.w; } }
        public dvec4 wxxw { get { return new dvec4(w, x, x, w); } set { w = value.x; x = value.y; x = value.z; w = value.w; } }
        public dvec4 wxyx { get { return new dvec4(w, x, y, x); } set { w = value.x; x = value.y; y = value.z; x = value.w; } }
        public dvec4 wxyy { get { return new dvec4(w, x, y, y); } set { w = value.x; x = value.y; y = value.z; y = value.w; } }
        public dvec4 wxyw { get { return new dvec4(w, x, y, w); } set { w = value.x; x = value.y; y = value.z; w = value.w; } }
        public dvec4 wxzx { get { return new dvec4(w, x, z, x); } set { w = value.x; x = value.y; z = value.z; x = value.w; } }
        public dvec4 wxzz { get { return new dvec4(w, x, z, z); } set { w = value.x; x = value.y; z = value.z; z = value.w; } }
        public dvec4 wxzw { get { return new dvec4(w, x, z, w); } set { w = value.x; x = value.y; z = value.z; w = value.w; } }
        public dvec4 wxwx { get { return new dvec4(w, x, w, x); } set { w = value.x; x = value.y; w = value.z; x = value.w; } }
        public dvec4 wxwy { get { return new dvec4(w, x, w, y); } set { w = value.x; x = value.y; w = value.z; y = value.w; } }
        public dvec4 wxwz { get { return new dvec4(w, x, w, z); } set { w = value.x; x = value.y; w = value.z; z = value.w; } }
        public dvec4 wxww { get { return new dvec4(w, x, w, w); } set { w = value.x; x = value.y; w = value.z; w = value.w; } }
        public dvec4 wyxx { get { return new dvec4(w, y, x, x); } set { w = value.x; y = value.y; x = value.z; x = value.w; } }
        public dvec4 wyxy { get { return new dvec4(w, y, x, y); } set { w = value.x; y = value.y; x = value.z; y = value.w; } }
        public dvec4 wyxw { get { return new dvec4(w, y, x, w); } set { w = value.x; y = value.y; x = value.z; w = value.w; } }
        public dvec4 wyyx { get { return new dvec4(w, y, y, x); } set { w = value.x; y = value.y; y = value.z; x = value.w; } }
        public dvec4 wyyy { get { return new dvec4(w, y, y, y); } set { w = value.x; y = value.y; y = value.z; y = value.w; } }
        public dvec4 wyyz { get { return new dvec4(w, y, y, z); } set { w = value.x; y = value.y; y = value.z; z = value.w; } }
        public dvec4 wyyw { get { return new dvec4(w, y, y, w); } set { w = value.x; y = value.y; y = value.z; w = value.w; } }
        public dvec4 wyzy { get { return new dvec4(w, y, z, y); } set { w = value.x; y = value.y; z = value.z; y = value.w; } }
        public dvec4 wyzz { get { return new dvec4(w, y, z, z); } set { w = value.x; y = value.y; z = value.z; z = value.w; } }
        public dvec4 wyzw { get { return new dvec4(w, y, z, w); } set { w = value.x; y = value.y; z = value.z; w = value.w; } }
        public dvec4 wywx { get { return new dvec4(w, y, w, x); } set { w = value.x; y = value.y; w = value.z; x = value.w; } }
        public dvec4 wywy { get { return new dvec4(w, y, w, y); } set { w = value.x; y = value.y; w = value.z; y = value.w; } }
        public dvec4 wywz { get { return new dvec4(w, y, w, z); } set { w = value.x; y = value.y; w = value.z; z = value.w; } }
        public dvec4 wyww { get { return new dvec4(w, y, w, w); } set { w = value.x; y = value.y; w = value.z; w = value.w; } }
        public dvec4 wzxx { get { return new dvec4(w, z, x, x); } set { w = value.x; z = value.y; x = value.z; x = value.w; } }
        public dvec4 wzxz { get { return new dvec4(w, z, x, z); } set { w = value.x; z = value.y; x = value.z; z = value.w; } }
        public dvec4 wzxw { get { return new dvec4(w, z, x, w); } set { w = value.x; z = value.y; x = value.z; w = value.w; } }
        public dvec4 wzyy { get { return new dvec4(w, z, y, y); } set { w = value.x; z = value.y; y = value.z; y = value.w; } }
        public dvec4 wzyz { get { return new dvec4(w, z, y, z); } set { w = value.x; z = value.y; y = value.z; z = value.w; } }
        public dvec4 wzyw { get { return new dvec4(w, z, y, w); } set { w = value.x; z = value.y; y = value.z; w = value.w; } }
        public dvec4 wzzx { get { return new dvec4(w, z, z, x); } set { w = value.x; z = value.y; z = value.z; x = value.w; } }
        public dvec4 wzzy { get { return new dvec4(w, z, z, y); } set { w = value.x; z = value.y; z = value.z; y = value.w; } }
        public dvec4 wzzz { get { return new dvec4(w, z, z, z); } set { w = value.x; z = value.y; z = value.z; z = value.w; } }
        public dvec4 wzzw { get { return new dvec4(w, z, z, w); } set { w = value.x; z = value.y; z = value.z; w = value.w; } }
        public dvec4 wzwx { get { return new dvec4(w, z, w, x); } set { w = value.x; z = value.y; w = value.z; x = value.w; } }
        public dvec4 wzwy { get { return new dvec4(w, z, w, y); } set { w = value.x; z = value.y; w = value.z; y = value.w; } }
        public dvec4 wzwz { get { return new dvec4(w, z, w, z); } set { w = value.x; z = value.y; w = value.z; z = value.w; } }
        public dvec4 wzww { get { return new dvec4(w, z, w, w); } set { w = value.x; z = value.y; w = value.z; w = value.w; } }
        public dvec4 wwxx { get { return new dvec4(w, w, x, x); } set { w = value.x; w = value.y; x = value.z; x = value.w; } }
        public dvec4 wwxy { get { return new dvec4(w, w, x, y); } set { w = value.x; w = value.y; x = value.z; y = value.w; } }
        public dvec4 wwxz { get { return new dvec4(w, w, x, z); } set { w = value.x; w = value.y; x = value.z; z = value.w; } }
        public dvec4 wwxw { get { return new dvec4(w, w, x, w); } set { w = value.x; w = value.y; x = value.z; w = value.w; } }
        public dvec4 wwyx { get { return new dvec4(w, w, y, x); } set { w = value.x; w = value.y; y = value.z; x = value.w; } }
        public dvec4 wwyy { get { return new dvec4(w, w, y, y); } set { w = value.x; w = value.y; y = value.z; y = value.w; } }
        public dvec4 wwyz { get { return new dvec4(w, w, y, z); } set { w = value.x; w = value.y; y = value.z; z = value.w; } }
        public dvec4 wwyw { get { return new dvec4(w, w, y, w); } set { w = value.x; w = value.y; y = value.z; w = value.w; } }
        public dvec4 wwzx { get { return new dvec4(w, w, z, x); } set { w = value.x; w = value.y; z = value.z; x = value.w; } }
        public dvec4 wwzy { get { return new dvec4(w, w, z, y); } set { w = value.x; w = value.y; z = value.z; y = value.w; } }
        public dvec4 wwzz { get { return new dvec4(w, w, z, z); } set { w = value.x; w = value.y; z = value.z; z = value.w; } }
        public dvec4 wwzw { get { return new dvec4(w, w, z, w); } set { w = value.x; w = value.y; z = value.z; w = value.w; } }
        public dvec4 wwwx { get { return new dvec4(w, w, w, x); } set { w = value.x; w = value.y; w = value.z; x = value.w; } }
        public dvec4 wwwy { get { return new dvec4(w, w, w, y); } set { w = value.x; w = value.y; w = value.z; y = value.w; } }
        public dvec4 wwwz { get { return new dvec4(w, w, w, z); } set { w = value.x; w = value.y; w = value.z; z = value.w; } }
        public dvec4 wwww { get { return new dvec4(w, w, w, w); } set { w = value.x; w = value.y; w = value.z; w = value.w; } }
#endif

#endif

#if COLOURS_ENABLED
#if CAPITALS_ENABLED
        public double A
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
#endif
        public double a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }

        // Starting with r

        public dvec4 rgba
        {
            get
            {
                return new dvec4(r, g, b, a);
            }
            set
            {
                r = value.r;
                g = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public dvec4 rabg
        {
            get
            {
                return new dvec4(r, a, b, g);
            }
            set
            {
                r = value.r;
                a = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public dvec4 ragb
        {
            get
            {
                return new dvec4(r, a, g, b);
            }
            set
            {
                r = value.r;
                a = value.g;
                g = value.b;
                b = value.a;
            }
        }
        public dvec4 rgab
        {
            get
            {
                return new dvec4(r, g, a, b);
            }
            set
            {
                r = value.r;
                g = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public dvec4 rbga
        {
            get
            {
                return new dvec4(r, b, g, a);
            }
            set
            {
                r = value.r;
                b = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public dvec4 rbag
        {
            get
            {
                return new dvec4(r, b, a, g);
            }
            set
            {
                r = value.r;
                b = value.g;
                a = value.b;
                g = value.a;
            }
        }





        //Starting with g (6)

        public dvec4 grba
        {
            get
            {
                return new dvec4(g, r, b, a);
            }
            set
            {
                g = value.r;
                r = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public dvec4 grab
        {
            get
            {
                return new dvec4(g, r, a, b);
            }
            set
            {
                g = value.r;
                r = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public dvec4 gbra
        {
            get
            {
                return new dvec4(g, b, r, a);
            }
            set
            {
                g = value.r;
                b = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public dvec4 gbar
        {
            get
            {
                return new dvec4(g, b, a, r);
            }
            set
            {
                g = value.r;
                b = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public dvec4 gabr
        {
            get
            {
                return new dvec4(g, a, b, r);
            }
            set
            {
                g = value.r;
                a = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public dvec4 garb
        {
            get
            {
                return new dvec4(g, a, r, b);
            }
            set
            {
                g = value.r;
                a = value.g;
                r = value.b;
                b = value.a;
            }
        }



        //Starting with b (6)

        public dvec4 brga
        {
            get
            {
                return new dvec4(b, r, g, a);
            }
            set
            {
                b = value.r;
                r = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public dvec4 bgra
        {
            get
            {
                return new dvec4(b, g, r, a);
            }
            set
            {
                b = value.r;
                g = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public dvec4 bgar
        {
            get
            {
                return new dvec4(b, g, a, r);
            }
            set
            {
                b = value.r;
                g = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public dvec4 brag
        {
            get
            {
                return new dvec4(b, r, a, g);
            }
            set
            {
                b = value.r;
                r = value.g;
                a = value.b;
                g = value.a;
            }
        }
        public dvec4 barg
        {
            get
            {
                return new dvec4(b, a, r, g);
            }
            set
            {
                b = value.r;
                a = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public dvec4 bagr
        {
            get
            {
                return new dvec4(b, a, g, r);
            }
            set
            {
                b = value.r;
                a = value.g;
                g = value.b;
                r = value.a;
            }
        }



        //Starting with a (6)

        public dvec4 argb
        {
            get
            {
                return new dvec4(a, r, g, b);
            }
            set
            {
                a = value.r;
                r = value.g;
                g = value.b;
                b = value.a;
            }
        }

        public dvec4 arbg
        {
            get
            {
                return new dvec4(a, r, b, g);
            }
            set
            {
                a = value.r;
                r = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public dvec4 agrb
        {
            get
            {
                return new dvec4(a, g, r, b);
            }
            set
            {
                a = value.r;
                g = value.g;
                r = value.b;
                b = value.a;
            }
        }
        public dvec4 agbr
        {
            get
            {
                return new dvec4(a, g, b, r);
            }
            set
            {
                a = value.r;
                g = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public dvec4 abrg
        {
            get
            {
                return new dvec4(a, b, r, g);
            }
            set
            {
                a = value.r;
                b = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public dvec4 abgr
        {
            get
            {
                return new dvec4(a, b, g, r);
            }
            set
            {
                a = value.r;
                b = value.g;
                g = value.b;
                r = value.a;
            }
        }


#if SWIZZLE_DUPLICATES_ENABLED
        // vec2 color duplicate
        public dvec2 aa
        {
            get { return new dvec2(a, a); }
            set { a = value.r; a = value.g; }
        }

        // dvec4 color duplicates
        public dvec4 rrrr { get { return new dvec4(r, r, r, r); } set { r = value.r; r = value.g; r = value.b; r = value.a; } }
        public dvec4 rrrg { get { return new dvec4(r, r, r, g); } set { r = value.r; r = value.g; r = value.b; g = value.a; } }
        public dvec4 rrrb { get { return new dvec4(r, r, r, b); } set { r = value.r; r = value.g; r = value.b; b = value.a; } }
        public dvec4 rrra { get { return new dvec4(r, r, r, a); } set { r = value.r; r = value.g; r = value.b; a = value.a; } }
        public dvec4 rrgr { get { return new dvec4(r, r, g, r); } set { r = value.r; r = value.g; g = value.b; r = value.a; } }
        public dvec4 rrgg { get { return new dvec4(r, r, g, g); } set { r = value.r; r = value.g; g = value.b; g = value.a; } }
        public dvec4 rrgb { get { return new dvec4(r, r, g, b); } set { r = value.r; r = value.g; g = value.b; b = value.a; } }
        public dvec4 rrga { get { return new dvec4(r, r, g, a); } set { r = value.r; r = value.g; g = value.b; a = value.a; } }
        public dvec4 rrbr { get { return new dvec4(r, r, b, r); } set { r = value.r; r = value.g; b = value.b; r = value.a; } }
        public dvec4 rrbg { get { return new dvec4(r, r, b, g); } set { r = value.r; r = value.g; b = value.b; g = value.a; } }
        public dvec4 rrbb { get { return new dvec4(r, r, b, b); } set { r = value.r; r = value.g; b = value.b; b = value.a; } }
        public dvec4 rrba { get { return new dvec4(r, r, b, a); } set { r = value.r; r = value.g; b = value.b; a = value.a; } }
        public dvec4 rrar { get { return new dvec4(r, r, a, r); } set { r = value.r; r = value.g; a = value.b; r = value.a; } }
        public dvec4 rrag { get { return new dvec4(r, r, a, g); } set { r = value.r; r = value.g; a = value.b; g = value.a; } }
        public dvec4 rrab { get { return new dvec4(r, r, a, b); } set { r = value.r; r = value.g; a = value.b; b = value.a; } }
        public dvec4 rraa { get { return new dvec4(r, r, a, a); } set { r = value.r; r = value.g; a = value.b; a = value.a; } }
        public dvec4 rgrr { get { return new dvec4(r, g, r, r); } set { r = value.r; g = value.g; r = value.b; r = value.a; } }
        public dvec4 rgrg { get { return new dvec4(r, g, r, g); } set { r = value.r; g = value.g; r = value.b; g = value.a; } }
        public dvec4 rgrb { get { return new dvec4(r, g, r, b); } set { r = value.r; g = value.g; r = value.b; b = value.a; } }
        public dvec4 rgra { get { return new dvec4(r, g, r, a); } set { r = value.r; g = value.g; r = value.b; a = value.a; } }
        public dvec4 rggr { get { return new dvec4(r, g, g, r); } set { r = value.r; g = value.g; g = value.b; r = value.a; } }
        public dvec4 rggg { get { return new dvec4(r, g, g, g); } set { r = value.r; g = value.g; g = value.b; g = value.a; } }
        public dvec4 rggb { get { return new dvec4(r, g, g, b); } set { r = value.r; g = value.g; g = value.b; b = value.a; } }
        public dvec4 rgga { get { return new dvec4(r, g, g, a); } set { r = value.r; g = value.g; g = value.b; a = value.a; } }
        public dvec4 rgbr { get { return new dvec4(r, g, b, r); } set { r = value.r; g = value.g; b = value.b; r = value.a; } }
        public dvec4 rgbg { get { return new dvec4(r, g, b, g); } set { r = value.r; g = value.g; b = value.b; g = value.a; } }
        public dvec4 rgbb { get { return new dvec4(r, g, b, b); } set { r = value.r; g = value.g; b = value.b; b = value.a; } }
        public dvec4 rgar { get { return new dvec4(r, g, a, r); } set { r = value.r; g = value.g; a = value.b; r = value.a; } }
        public dvec4 rgag { get { return new dvec4(r, g, a, g); } set { r = value.r; g = value.g; a = value.b; g = value.a; } }
        public dvec4 rgaa { get { return new dvec4(r, g, a, a); } set { r = value.r; g = value.g; a = value.b; a = value.a; } }
        public dvec4 rbrr { get { return new dvec4(r, b, r, r); } set { r = value.r; b = value.g; r = value.b; r = value.a; } }
        public dvec4 rbrg { get { return new dvec4(r, b, r, g); } set { r = value.r; b = value.g; r = value.b; g = value.a; } }
        public dvec4 rbrb { get { return new dvec4(r, b, r, b); } set { r = value.r; b = value.g; r = value.b; b = value.a; } }
        public dvec4 rbra { get { return new dvec4(r, b, r, a); } set { r = value.r; b = value.g; r = value.b; a = value.a; } }
        public dvec4 rbgr { get { return new dvec4(r, b, g, r); } set { r = value.r; b = value.g; g = value.b; r = value.a; } }
        public dvec4 rbgg { get { return new dvec4(r, b, g, g); } set { r = value.r; b = value.g; g = value.b; g = value.a; } }
        public dvec4 rbgb { get { return new dvec4(r, b, g, b); } set { r = value.r; b = value.g; g = value.b; b = value.a; } }
        public dvec4 rbbr { get { return new dvec4(r, b, b, r); } set { r = value.r; b = value.g; b = value.b; r = value.a; } }
        public dvec4 rbbg { get { return new dvec4(r, b, b, g); } set { r = value.r; b = value.g; b = value.b; g = value.a; } }
        public dvec4 rbbb { get { return new dvec4(r, b, b, b); } set { r = value.r; b = value.g; b = value.b; b = value.a; } }
        public dvec4 rbba { get { return new dvec4(r, b, b, a); } set { r = value.r; b = value.g; b = value.b; a = value.a; } }
        public dvec4 rbar { get { return new dvec4(r, b, a, r); } set { r = value.r; b = value.g; a = value.b; r = value.a; } }
        public dvec4 rbab { get { return new dvec4(r, b, a, b); } set { r = value.r; b = value.g; a = value.b; b = value.a; } }
        public dvec4 rbaa { get { return new dvec4(r, b, a, a); } set { r = value.r; b = value.g; a = value.b; a = value.a; } }
        public dvec4 rarr { get { return new dvec4(r, a, r, r); } set { r = value.r; a = value.g; r = value.b; r = value.a; } }
        public dvec4 rarg { get { return new dvec4(r, a, r, g); } set { r = value.r; a = value.g; r = value.b; g = value.a; } }
        public dvec4 rarb { get { return new dvec4(r, a, r, b); } set { r = value.r; a = value.g; r = value.b; b = value.a; } }
        public dvec4 rara { get { return new dvec4(r, a, r, a); } set { r = value.r; a = value.g; r = value.b; a = value.a; } }
        public dvec4 ragr { get { return new dvec4(r, a, g, r); } set { r = value.r; a = value.g; g = value.b; r = value.a; } }
        public dvec4 ragg { get { return new dvec4(r, a, g, g); } set { r = value.r; a = value.g; g = value.b; g = value.a; } }
        public dvec4 raga { get { return new dvec4(r, a, g, a); } set { r = value.r; a = value.g; g = value.b; a = value.a; } }
        public dvec4 rabr { get { return new dvec4(r, a, b, r); } set { r = value.r; a = value.g; b = value.b; r = value.a; } }
        public dvec4 rabb { get { return new dvec4(r, a, b, b); } set { r = value.r; a = value.g; b = value.b; b = value.a; } }
        public dvec4 raba { get { return new dvec4(r, a, b, a); } set { r = value.r; a = value.g; b = value.b; a = value.a; } }
        public dvec4 raar { get { return new dvec4(r, a, a, r); } set { r = value.r; a = value.g; a = value.b; r = value.a; } }
        public dvec4 raag { get { return new dvec4(r, a, a, g); } set { r = value.r; a = value.g; a = value.b; g = value.a; } }
        public dvec4 raab { get { return new dvec4(r, a, a, b); } set { r = value.r; a = value.g; a = value.b; b = value.a; } }
        public dvec4 raaa { get { return new dvec4(r, a, a, a); } set { r = value.r; a = value.g; a = value.b; a = value.a; } }
        public dvec4 grrr { get { return new dvec4(g, r, r, r); } set { g = value.r; r = value.g; r = value.b; r = value.a; } }
        public dvec4 grrg { get { return new dvec4(g, r, r, g); } set { g = value.r; r = value.g; r = value.b; g = value.a; } }
        public dvec4 grrb { get { return new dvec4(g, r, r, b); } set { g = value.r; r = value.g; r = value.b; b = value.a; } }
        public dvec4 grra { get { return new dvec4(g, r, r, a); } set { g = value.r; r = value.g; r = value.b; a = value.a; } }
        public dvec4 grgr { get { return new dvec4(g, r, g, r); } set { g = value.r; r = value.g; g = value.b; r = value.a; } }
        public dvec4 grgg { get { return new dvec4(g, r, g, g); } set { g = value.r; r = value.g; g = value.b; g = value.a; } }
        public dvec4 grgb { get { return new dvec4(g, r, g, b); } set { g = value.r; r = value.g; g = value.b; b = value.a; } }
        public dvec4 grga { get { return new dvec4(g, r, g, a); } set { g = value.r; r = value.g; g = value.b; a = value.a; } }
        public dvec4 grbr { get { return new dvec4(g, r, b, r); } set { g = value.r; r = value.g; b = value.b; r = value.a; } }
        public dvec4 grbg { get { return new dvec4(g, r, b, g); } set { g = value.r; r = value.g; b = value.b; g = value.a; } }
        public dvec4 grbb { get { return new dvec4(g, r, b, b); } set { g = value.r; r = value.g; b = value.b; b = value.a; } }
        public dvec4 grar { get { return new dvec4(g, r, a, r); } set { g = value.r; r = value.g; a = value.b; r = value.a; } }
        public dvec4 grag { get { return new dvec4(g, r, a, g); } set { g = value.r; r = value.g; a = value.b; g = value.a; } }
        public dvec4 graa { get { return new dvec4(g, r, a, a); } set { g = value.r; r = value.g; a = value.b; a = value.a; } }
        public dvec4 ggrr { get { return new dvec4(g, g, r, r); } set { g = value.r; g = value.g; r = value.b; r = value.a; } }
        public dvec4 ggrg { get { return new dvec4(g, g, r, g); } set { g = value.r; g = value.g; r = value.b; g = value.a; } }
        public dvec4 ggrb { get { return new dvec4(g, g, r, b); } set { g = value.r; g = value.g; r = value.b; b = value.a; } }
        public dvec4 ggra { get { return new dvec4(g, g, r, a); } set { g = value.r; g = value.g; r = value.b; a = value.a; } }
        public dvec4 gggr { get { return new dvec4(g, g, g, r); } set { g = value.r; g = value.g; g = value.b; r = value.a; } }
        public dvec4 gggg { get { return new dvec4(g, g, g, g); } set { g = value.r; g = value.g; g = value.b; g = value.a; } }
        public dvec4 gggb { get { return new dvec4(g, g, g, b); } set { g = value.r; g = value.g; g = value.b; b = value.a; } }
        public dvec4 ggga { get { return new dvec4(g, g, g, a); } set { g = value.r; g = value.g; g = value.b; a = value.a; } }
        public dvec4 ggbr { get { return new dvec4(g, g, b, r); } set { g = value.r; g = value.g; b = value.b; r = value.a; } }
        public dvec4 ggbg { get { return new dvec4(g, g, b, g); } set { g = value.r; g = value.g; b = value.b; g = value.a; } }
        public dvec4 ggbb { get { return new dvec4(g, g, b, b); } set { g = value.r; g = value.g; b = value.b; b = value.a; } }
        public dvec4 ggba { get { return new dvec4(g, g, b, a); } set { g = value.r; g = value.g; b = value.b; a = value.a; } }
        public dvec4 ggar { get { return new dvec4(g, g, a, r); } set { g = value.r; g = value.g; a = value.b; r = value.a; } }
        public dvec4 ggag { get { return new dvec4(g, g, a, g); } set { g = value.r; g = value.g; a = value.b; g = value.a; } }
        public dvec4 ggab { get { return new dvec4(g, g, a, b); } set { g = value.r; g = value.g; a = value.b; b = value.a; } }
        public dvec4 ggaa { get { return new dvec4(g, g, a, a); } set { g = value.r; g = value.g; a = value.b; a = value.a; } }
        public dvec4 gbrr { get { return new dvec4(g, b, r, r); } set { g = value.r; b = value.g; r = value.b; r = value.a; } }
        public dvec4 gbrg { get { return new dvec4(g, b, r, g); } set { g = value.r; b = value.g; r = value.b; g = value.a; } }
        public dvec4 gbrb { get { return new dvec4(g, b, r, b); } set { g = value.r; b = value.g; r = value.b; b = value.a; } }
        public dvec4 gbgr { get { return new dvec4(g, b, g, r); } set { g = value.r; b = value.g; g = value.b; r = value.a; } }
        public dvec4 gbgg { get { return new dvec4(g, b, g, g); } set { g = value.r; b = value.g; g = value.b; g = value.a; } }
        public dvec4 gbgb { get { return new dvec4(g, b, g, b); } set { g = value.r; b = value.g; g = value.b; b = value.a; } }
        public dvec4 gbga { get { return new dvec4(g, b, g, a); } set { g = value.r; b = value.g; g = value.b; a = value.a; } }
        public dvec4 gbbr { get { return new dvec4(g, b, b, r); } set { g = value.r; b = value.g; b = value.b; r = value.a; } }
        public dvec4 gbbg { get { return new dvec4(g, b, b, g); } set { g = value.r; b = value.g; b = value.b; g = value.a; } }
        public dvec4 gbbb { get { return new dvec4(g, b, b, b); } set { g = value.r; b = value.g; b = value.b; b = value.a; } }
        public dvec4 gbba { get { return new dvec4(g, b, b, a); } set { g = value.r; b = value.g; b = value.b; a = value.a; } }
        public dvec4 gbag { get { return new dvec4(g, b, a, g); } set { g = value.r; b = value.g; a = value.b; g = value.a; } }
        public dvec4 gbab { get { return new dvec4(g, b, a, b); } set { g = value.r; b = value.g; a = value.b; b = value.a; } }
        public dvec4 gbaa { get { return new dvec4(g, b, a, a); } set { g = value.r; b = value.g; a = value.b; a = value.a; } }
        public dvec4 garr { get { return new dvec4(g, a, r, r); } set { g = value.r; a = value.g; r = value.b; r = value.a; } }
        public dvec4 garg { get { return new dvec4(g, a, r, g); } set { g = value.r; a = value.g; r = value.b; g = value.a; } }
        public dvec4 gara { get { return new dvec4(g, a, r, a); } set { g = value.r; a = value.g; r = value.b; a = value.a; } }
        public dvec4 gagr { get { return new dvec4(g, a, g, r); } set { g = value.r; a = value.g; g = value.b; r = value.a; } }
        public dvec4 gagg { get { return new dvec4(g, a, g, g); } set { g = value.r; a = value.g; g = value.b; g = value.a; } }
        public dvec4 gagb { get { return new dvec4(g, a, g, b); } set { g = value.r; a = value.g; g = value.b; b = value.a; } }
        public dvec4 gaga { get { return new dvec4(g, a, g, a); } set { g = value.r; a = value.g; g = value.b; a = value.a; } }
        public dvec4 gabg { get { return new dvec4(g, a, b, g); } set { g = value.r; a = value.g; b = value.b; g = value.a; } }
        public dvec4 gabb { get { return new dvec4(g, a, b, b); } set { g = value.r; a = value.g; b = value.b; b = value.a; } }
        public dvec4 gaba { get { return new dvec4(g, a, b, a); } set { g = value.r; a = value.g; b = value.b; a = value.a; } }
        public dvec4 gaar { get { return new dvec4(g, a, a, r); } set { g = value.r; a = value.g; a = value.b; r = value.a; } }
        public dvec4 gaag { get { return new dvec4(g, a, a, g); } set { g = value.r; a = value.g; a = value.b; g = value.a; } }
        public dvec4 gaab { get { return new dvec4(g, a, a, b); } set { g = value.r; a = value.g; a = value.b; b = value.a; } }
        public dvec4 gaaa { get { return new dvec4(g, a, a, a); } set { g = value.r; a = value.g; a = value.b; a = value.a; } }
        public dvec4 brrr { get { return new dvec4(b, r, r, r); } set { b = value.r; r = value.g; r = value.b; r = value.a; } }
        public dvec4 brrg { get { return new dvec4(b, r, r, g); } set { b = value.r; r = value.g; r = value.b; g = value.a; } }
        public dvec4 brrb { get { return new dvec4(b, r, r, b); } set { b = value.r; r = value.g; r = value.b; b = value.a; } }
        public dvec4 brra { get { return new dvec4(b, r, r, a); } set { b = value.r; r = value.g; r = value.b; a = value.a; } }
        public dvec4 brgr { get { return new dvec4(b, r, g, r); } set { b = value.r; r = value.g; g = value.b; r = value.a; } }
        public dvec4 brgg { get { return new dvec4(b, r, g, g); } set { b = value.r; r = value.g; g = value.b; g = value.a; } }
        public dvec4 brgb { get { return new dvec4(b, r, g, b); } set { b = value.r; r = value.g; g = value.b; b = value.a; } }
        public dvec4 brbr { get { return new dvec4(b, r, b, r); } set { b = value.r; r = value.g; b = value.b; r = value.a; } }
        public dvec4 brbg { get { return new dvec4(b, r, b, g); } set { b = value.r; r = value.g; b = value.b; g = value.a; } }
        public dvec4 brbb { get { return new dvec4(b, r, b, b); } set { b = value.r; r = value.g; b = value.b; b = value.a; } }
        public dvec4 brba { get { return new dvec4(b, r, b, a); } set { b = value.r; r = value.g; b = value.b; a = value.a; } }
        public dvec4 brar { get { return new dvec4(b, r, a, r); } set { b = value.r; r = value.g; a = value.b; r = value.a; } }
        public dvec4 brab { get { return new dvec4(b, r, a, b); } set { b = value.r; r = value.g; a = value.b; b = value.a; } }
        public dvec4 braa { get { return new dvec4(b, r, a, a); } set { b = value.r; r = value.g; a = value.b; a = value.a; } }
        public dvec4 bgrr { get { return new dvec4(b, g, r, r); } set { b = value.r; g = value.g; r = value.b; r = value.a; } }
        public dvec4 bgrg { get { return new dvec4(b, g, r, g); } set { b = value.r; g = value.g; r = value.b; g = value.a; } }
        public dvec4 bgrb { get { return new dvec4(b, g, r, b); } set { b = value.r; g = value.g; r = value.b; b = value.a; } }
        public dvec4 bggr { get { return new dvec4(b, g, g, r); } set { b = value.r; g = value.g; g = value.b; r = value.a; } }
        public dvec4 bggg { get { return new dvec4(b, g, g, g); } set { b = value.r; g = value.g; g = value.b; g = value.a; } }
        public dvec4 bggb { get { return new dvec4(b, g, g, b); } set { b = value.r; g = value.g; g = value.b; b = value.a; } }
        public dvec4 bgga { get { return new dvec4(b, g, g, a); } set { b = value.r; g = value.g; g = value.b; a = value.a; } }
        public dvec4 bgbr { get { return new dvec4(b, g, b, r); } set { b = value.r; g = value.g; b = value.b; r = value.a; } }
        public dvec4 bgbg { get { return new dvec4(b, g, b, g); } set { b = value.r; g = value.g; b = value.b; g = value.a; } }
        public dvec4 bgbb { get { return new dvec4(b, g, b, b); } set { b = value.r; g = value.g; b = value.b; b = value.a; } }
        public dvec4 bgba { get { return new dvec4(b, g, b, a); } set { b = value.r; g = value.g; b = value.b; a = value.a; } }
        public dvec4 bgag { get { return new dvec4(b, g, a, g); } set { b = value.r; g = value.g; a = value.b; g = value.a; } }
        public dvec4 bgab { get { return new dvec4(b, g, a, b); } set { b = value.r; g = value.g; a = value.b; b = value.a; } }
        public dvec4 bgaa { get { return new dvec4(b, g, a, a); } set { b = value.r; g = value.g; a = value.b; a = value.a; } }
        public dvec4 bbrr { get { return new dvec4(b, b, r, r); } set { b = value.r; b = value.g; r = value.b; r = value.a; } }
        public dvec4 bbrg { get { return new dvec4(b, b, r, g); } set { b = value.r; b = value.g; r = value.b; g = value.a; } }
        public dvec4 bbrb { get { return new dvec4(b, b, r, b); } set { b = value.r; b = value.g; r = value.b; b = value.a; } }
        public dvec4 bbra { get { return new dvec4(b, b, r, a); } set { b = value.r; b = value.g; r = value.b; a = value.a; } }
        public dvec4 bbgr { get { return new dvec4(b, b, g, r); } set { b = value.r; b = value.g; g = value.b; r = value.a; } }
        public dvec4 bbgg { get { return new dvec4(b, b, g, g); } set { b = value.r; b = value.g; g = value.b; g = value.a; } }
        public dvec4 bbgb { get { return new dvec4(b, b, g, b); } set { b = value.r; b = value.g; g = value.b; b = value.a; } }
        public dvec4 bbga { get { return new dvec4(b, b, g, a); } set { b = value.r; b = value.g; g = value.b; a = value.a; } }
        public dvec4 bbbr { get { return new dvec4(b, b, b, r); } set { b = value.r; b = value.g; b = value.b; r = value.a; } }
        public dvec4 bbbg { get { return new dvec4(b, b, b, g); } set { b = value.r; b = value.g; b = value.b; g = value.a; } }
        public dvec4 bbbb { get { return new dvec4(b, b, b, b); } set { b = value.r; b = value.g; b = value.b; b = value.a; } }
        public dvec4 bbba { get { return new dvec4(b, b, b, a); } set { b = value.r; b = value.g; b = value.b; a = value.a; } }
        public dvec4 bbar { get { return new dvec4(b, b, a, r); } set { b = value.r; b = value.g; a = value.b; r = value.a; } }
        public dvec4 bbag { get { return new dvec4(b, b, a, g); } set { b = value.r; b = value.g; a = value.b; g = value.a; } }
        public dvec4 bbab { get { return new dvec4(b, b, a, b); } set { b = value.r; b = value.g; a = value.b; b = value.a; } }
        public dvec4 bbaa { get { return new dvec4(b, b, a, a); } set { b = value.r; b = value.g; a = value.b; a = value.a; } }
        public dvec4 barr { get { return new dvec4(b, a, r, r); } set { b = value.r; a = value.g; r = value.b; r = value.a; } }
        public dvec4 barb { get { return new dvec4(b, a, r, b); } set { b = value.r; a = value.g; r = value.b; b = value.a; } }
        public dvec4 bara { get { return new dvec4(b, a, r, a); } set { b = value.r; a = value.g; r = value.b; a = value.a; } }
        public dvec4 bagg { get { return new dvec4(b, a, g, g); } set { b = value.r; a = value.g; g = value.b; g = value.a; } }
        public dvec4 bagb { get { return new dvec4(b, a, g, b); } set { b = value.r; a = value.g; g = value.b; b = value.a; } }
        public dvec4 baga { get { return new dvec4(b, a, g, a); } set { b = value.r; a = value.g; g = value.b; a = value.a; } }
        public dvec4 babr { get { return new dvec4(b, a, b, r); } set { b = value.r; a = value.g; b = value.b; r = value.a; } }
        public dvec4 babg { get { return new dvec4(b, a, b, g); } set { b = value.r; a = value.g; b = value.b; g = value.a; } }
        public dvec4 babb { get { return new dvec4(b, a, b, b); } set { b = value.r; a = value.g; b = value.b; b = value.a; } }
        public dvec4 baba { get { return new dvec4(b, a, b, a); } set { b = value.r; a = value.g; b = value.b; a = value.a; } }
        public dvec4 baar { get { return new dvec4(b, a, a, r); } set { b = value.r; a = value.g; a = value.b; r = value.a; } }
        public dvec4 baag { get { return new dvec4(b, a, a, g); } set { b = value.r; a = value.g; a = value.b; g = value.a; } }
        public dvec4 baab { get { return new dvec4(b, a, a, b); } set { b = value.r; a = value.g; a = value.b; b = value.a; } }
        public dvec4 baaa { get { return new dvec4(b, a, a, a); } set { b = value.r; a = value.g; a = value.b; a = value.a; } }
        public dvec4 arrr { get { return new dvec4(a, r, r, r); } set { a = value.r; r = value.g; r = value.b; r = value.a; } }
        public dvec4 arrg { get { return new dvec4(a, r, r, g); } set { a = value.r; r = value.g; r = value.b; g = value.a; } }
        public dvec4 arrb { get { return new dvec4(a, r, r, b); } set { a = value.r; r = value.g; r = value.b; b = value.a; } }
        public dvec4 arra { get { return new dvec4(a, r, r, a); } set { a = value.r; r = value.g; r = value.b; a = value.a; } }
        public dvec4 argr { get { return new dvec4(a, r, g, r); } set { a = value.r; r = value.g; g = value.b; r = value.a; } }
        public dvec4 argg { get { return new dvec4(a, r, g, g); } set { a = value.r; r = value.g; g = value.b; g = value.a; } }
        public dvec4 arga { get { return new dvec4(a, r, g, a); } set { a = value.r; r = value.g; g = value.b; a = value.a; } }
        public dvec4 arbr { get { return new dvec4(a, r, b, r); } set { a = value.r; r = value.g; b = value.b; r = value.a; } }
        public dvec4 arbb { get { return new dvec4(a, r, b, b); } set { a = value.r; r = value.g; b = value.b; b = value.a; } }
        public dvec4 arba { get { return new dvec4(a, r, b, a); } set { a = value.r; r = value.g; b = value.b; a = value.a; } }
        public dvec4 arar { get { return new dvec4(a, r, a, r); } set { a = value.r; r = value.g; a = value.b; r = value.a; } }
        public dvec4 arag { get { return new dvec4(a, r, a, g); } set { a = value.r; r = value.g; a = value.b; g = value.a; } }
        public dvec4 arab { get { return new dvec4(a, r, a, b); } set { a = value.r; r = value.g; a = value.b; b = value.a; } }
        public dvec4 araa { get { return new dvec4(a, r, a, a); } set { a = value.r; r = value.g; a = value.b; a = value.a; } }
        public dvec4 agrr { get { return new dvec4(a, g, r, r); } set { a = value.r; g = value.g; r = value.b; r = value.a; } }
        public dvec4 agrg { get { return new dvec4(a, g, r, g); } set { a = value.r; g = value.g; r = value.b; g = value.a; } }
        public dvec4 agra { get { return new dvec4(a, g, r, a); } set { a = value.r; g = value.g; r = value.b; a = value.a; } }
        public dvec4 aggr { get { return new dvec4(a, g, g, r); } set { a = value.r; g = value.g; g = value.b; r = value.a; } }
        public dvec4 aggg { get { return new dvec4(a, g, g, g); } set { a = value.r; g = value.g; g = value.b; g = value.a; } }
        public dvec4 aggb { get { return new dvec4(a, g, g, b); } set { a = value.r; g = value.g; g = value.b; b = value.a; } }
        public dvec4 agga { get { return new dvec4(a, g, g, a); } set { a = value.r; g = value.g; g = value.b; a = value.a; } }
        public dvec4 agbg { get { return new dvec4(a, g, b, g); } set { a = value.r; g = value.g; b = value.b; g = value.a; } }
        public dvec4 agbb { get { return new dvec4(a, g, b, b); } set { a = value.r; g = value.g; b = value.b; b = value.a; } }
        public dvec4 agba { get { return new dvec4(a, g, b, a); } set { a = value.r; g = value.g; b = value.b; a = value.a; } }
        public dvec4 agar { get { return new dvec4(a, g, a, r); } set { a = value.r; g = value.g; a = value.b; r = value.a; } }
        public dvec4 agag { get { return new dvec4(a, g, a, g); } set { a = value.r; g = value.g; a = value.b; g = value.a; } }
        public dvec4 agab { get { return new dvec4(a, g, a, b); } set { a = value.r; g = value.g; a = value.b; b = value.a; } }
        public dvec4 agaa { get { return new dvec4(a, g, a, a); } set { a = value.r; g = value.g; a = value.b; a = value.a; } }
        public dvec4 abrr { get { return new dvec4(a, b, r, r); } set { a = value.r; b = value.g; r = value.b; r = value.a; } }
        public dvec4 abrb { get { return new dvec4(a, b, r, b); } set { a = value.r; b = value.g; r = value.b; b = value.a; } }
        public dvec4 abra { get { return new dvec4(a, b, r, a); } set { a = value.r; b = value.g; r = value.b; a = value.a; } }
        public dvec4 abgg { get { return new dvec4(a, b, g, g); } set { a = value.r; b = value.g; g = value.b; g = value.a; } }
        public dvec4 abgb { get { return new dvec4(a, b, g, b); } set { a = value.r; b = value.g; g = value.b; b = value.a; } }
        public dvec4 abga { get { return new dvec4(a, b, g, a); } set { a = value.r; b = value.g; g = value.b; a = value.a; } }
        public dvec4 abbr { get { return new dvec4(a, b, b, r); } set { a = value.r; b = value.g; b = value.b; r = value.a; } }
        public dvec4 abbg { get { return new dvec4(a, b, b, g); } set { a = value.r; b = value.g; b = value.b; g = value.a; } }
        public dvec4 abbb { get { return new dvec4(a, b, b, b); } set { a = value.r; b = value.g; b = value.b; b = value.a; } }
        public dvec4 abba { get { return new dvec4(a, b, b, a); } set { a = value.r; b = value.g; b = value.b; a = value.a; } }
        public dvec4 abar { get { return new dvec4(a, b, a, r); } set { a = value.r; b = value.g; a = value.b; r = value.a; } }
        public dvec4 abag { get { return new dvec4(a, b, a, g); } set { a = value.r; b = value.g; a = value.b; g = value.a; } }
        public dvec4 abab { get { return new dvec4(a, b, a, b); } set { a = value.r; b = value.g; a = value.b; b = value.a; } }
        public dvec4 abaa { get { return new dvec4(a, b, a, a); } set { a = value.r; b = value.g; a = value.b; a = value.a; } }
        public dvec4 aarr { get { return new dvec4(a, a, r, r); } set { a = value.r; a = value.g; r = value.b; r = value.a; } }
        public dvec4 aarg { get { return new dvec4(a, a, r, g); } set { a = value.r; a = value.g; r = value.b; g = value.a; } }
        public dvec4 aarb { get { return new dvec4(a, a, r, b); } set { a = value.r; a = value.g; r = value.b; b = value.a; } }
        public dvec4 aara { get { return new dvec4(a, a, r, a); } set { a = value.r; a = value.g; r = value.b; a = value.a; } }
        public dvec4 aagr { get { return new dvec4(a, a, g, r); } set { a = value.r; a = value.g; g = value.b; r = value.a; } }
        public dvec4 aagg { get { return new dvec4(a, a, g, g); } set { a = value.r; a = value.g; g = value.b; g = value.a; } }
        public dvec4 aagb { get { return new dvec4(a, a, g, b); } set { a = value.r; a = value.g; g = value.b; b = value.a; } }
        public dvec4 aaga { get { return new dvec4(a, a, g, a); } set { a = value.r; a = value.g; g = value.b; a = value.a; } }
        public dvec4 aabr { get { return new dvec4(a, a, b, r); } set { a = value.r; a = value.g; b = value.b; r = value.a; } }
        public dvec4 aabg { get { return new dvec4(a, a, b, g); } set { a = value.r; a = value.g; b = value.b; g = value.a; } }
        public dvec4 aabb { get { return new dvec4(a, a, b, b); } set { a = value.r; a = value.g; b = value.b; b = value.a; } }
        public dvec4 aaba { get { return new dvec4(a, a, b, a); } set { a = value.r; a = value.g; b = value.b; a = value.a; } }
        public dvec4 aaar { get { return new dvec4(a, a, a, r); } set { a = value.r; a = value.g; a = value.b; r = value.a; } }
        public dvec4 aaag { get { return new dvec4(a, a, a, g); } set { a = value.r; a = value.g; a = value.b; g = value.a; } }
        public dvec4 aaab { get { return new dvec4(a, a, a, b); } set { a = value.r; a = value.g; a = value.b; b = value.a; } }
        public dvec4 aaaa { get { return new dvec4(a, a, a, a); } set { a = value.r; a = value.g; a = value.b; a = value.a; } }
#endif
#endif
    }
}
#endif
#endif