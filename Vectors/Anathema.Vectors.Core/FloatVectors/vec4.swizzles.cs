
#if FLOATS_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec4 : vec3
    {

#if CAPITALS_ENABLED
        public float W
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

        public vec4 xyzw
        {
            get
            {
                return new vec4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public vec4 xwzy
        {
            get
            {
                return new vec4(x, w, z, y);
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public vec4 xwyz
        {
            get
            {
                return new vec4(x, w, y, z);
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        public vec4 xywz
        {
            get
            {
                return new vec4(x, y, w, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public vec4 xzyw
        {
            get
            {
                return new vec4(x, z, y, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public vec4 xzwy
        {
            get
            {
                return new vec4(x, z, w, y);
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

        public vec4 yxzw
        {
            get
            {
                return new vec4(y, x, z, w);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public vec4 yxwz
        {
            get
            {
                return new vec4(y, x, w, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public vec4 yzxw
        {
            get
            {
                return new vec4(y, z, x, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public vec4 yzwx
        {
            get
            {
                return new vec4(y, z, w, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public vec4 ywzx
        {
            get
            {
                return new vec4(y, w, z, x);
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public vec4 ywxz
        {
            get
            {
                return new vec4(y, w, x, z);
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

        public vec4 zxyw
        {
            get
            {
                return new vec4(z, x, y, w);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public vec4 zyxw
        {
            get
            {
                return new vec4(z, y, x, w);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public vec4 zywx
        {
            get
            {
                return new vec4(z, y, w, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public vec4 zxwy
        {
            get
            {
                return new vec4(z, x, w, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        public vec4 zwxy
        {
            get
            {
                return new vec4(z, w, x, y);
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public vec4 zwyx
        {
            get
            {
                return new vec4(z, w, y, x);
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

        public vec4 wxyz
        {
            get
            {
                return new vec4(w, x, y, z);
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        public vec4 wxzy
        {
            get
            {
                return new vec4(w, x, z, y);
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public vec4 wyxz
        {
            get
            {
                return new vec4(w, y, x, z);
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        public vec4 wyzx
        {
            get
            {
                return new vec4(w, y, z, x);
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public vec4 wzxy
        {
            get
            {
                return new vec4(w, z, x, y);
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public vec4 wzyx
        {
            get
            {
                return new vec4(w, z, y, x);
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
        public vec2 ww
        {
            get { return new vec2(w, w); }
            set { w = value.x; w = value.y; }
        }

        // vec4 duplicates - all combinations with at least one duplicate component
        public vec4 xxxx { get { return new vec4(x, x, x, x); } set { x = value.x; x = value.y; x = value.z; x = value.w; } }
        public vec4 xxxy { get { return new vec4(x, x, x, y); } set { x = value.x; x = value.y; x = value.z; y = value.w; } }
        public vec4 xxxz { get { return new vec4(x, x, x, z); } set { x = value.x; x = value.y; x = value.z; z = value.w; } }
        public vec4 xxxw { get { return new vec4(x, x, x, w); } set { x = value.x; x = value.y; x = value.z; w = value.w; } }
        public vec4 xxyx { get { return new vec4(x, x, y, x); } set { x = value.x; x = value.y; y = value.z; x = value.w; } }
        public vec4 xxyy { get { return new vec4(x, x, y, y); } set { x = value.x; x = value.y; y = value.z; y = value.w; } }
        public vec4 xxyz { get { return new vec4(x, x, y, z); } set { x = value.x; x = value.y; y = value.z; z = value.w; } }
        public vec4 xxyw { get { return new vec4(x, x, y, w); } set { x = value.x; x = value.y; y = value.z; w = value.w; } }
        public vec4 xxzx { get { return new vec4(x, x, z, x); } set { x = value.x; x = value.y; z = value.z; x = value.w; } }
        public vec4 xxzy { get { return new vec4(x, x, z, y); } set { x = value.x; x = value.y; z = value.z; y = value.w; } }
        public vec4 xxzz { get { return new vec4(x, x, z, z); } set { x = value.x; x = value.y; z = value.z; z = value.w; } }
        public vec4 xxzw { get { return new vec4(x, x, z, w); } set { x = value.x; x = value.y; z = value.z; w = value.w; } }
        public vec4 xxwx { get { return new vec4(x, x, w, x); } set { x = value.x; x = value.y; w = value.z; x = value.w; } }
        public vec4 xxwy { get { return new vec4(x, x, w, y); } set { x = value.x; x = value.y; w = value.z; y = value.w; } }
        public vec4 xxwz { get { return new vec4(x, x, w, z); } set { x = value.x; x = value.y; w = value.z; z = value.w; } }
        public vec4 xxww { get { return new vec4(x, x, w, w); } set { x = value.x; x = value.y; w = value.z; w = value.w; } }
        public vec4 xyxx { get { return new vec4(x, y, x, x); } set { x = value.x; y = value.y; x = value.z; x = value.w; } }
        public vec4 xyxy { get { return new vec4(x, y, x, y); } set { x = value.x; y = value.y; x = value.z; y = value.w; } }
        public vec4 xyxz { get { return new vec4(x, y, x, z); } set { x = value.x; y = value.y; x = value.z; z = value.w; } }
        public vec4 xyxw { get { return new vec4(x, y, x, w); } set { x = value.x; y = value.y; x = value.z; w = value.w; } }
        public vec4 xyyx { get { return new vec4(x, y, y, x); } set { x = value.x; y = value.y; y = value.z; x = value.w; } }
        public vec4 xyyy { get { return new vec4(x, y, y, y); } set { x = value.x; y = value.y; y = value.z; y = value.w; } }
        public vec4 xyyz { get { return new vec4(x, y, y, z); } set { x = value.x; y = value.y; y = value.z; z = value.w; } }
        public vec4 xyyw { get { return new vec4(x, y, y, w); } set { x = value.x; y = value.y; y = value.z; w = value.w; } }
        public vec4 xyzx { get { return new vec4(x, y, z, x); } set { x = value.x; y = value.y; z = value.z; x = value.w; } }
        public vec4 xyzy { get { return new vec4(x, y, z, y); } set { x = value.x; y = value.y; z = value.z; y = value.w; } }
        public vec4 xyzz { get { return new vec4(x, y, z, z); } set { x = value.x; y = value.y; z = value.z; z = value.w; } }
        public vec4 xywx { get { return new vec4(x, y, w, x); } set { x = value.x; y = value.y; w = value.z; x = value.w; } }
        public vec4 xywy { get { return new vec4(x, y, w, y); } set { x = value.x; y = value.y; w = value.z; y = value.w; } }
        public vec4 xyww { get { return new vec4(x, y, w, w); } set { x = value.x; y = value.y; w = value.z; w = value.w; } }
        public vec4 xzxx { get { return new vec4(x, z, x, x); } set { x = value.x; z = value.y; x = value.z; x = value.w; } }
        public vec4 xzxy { get { return new vec4(x, z, x, y); } set { x = value.x; z = value.y; x = value.z; y = value.w; } }
        public vec4 xzxz { get { return new vec4(x, z, x, z); } set { x = value.x; z = value.y; x = value.z; z = value.w; } }
        public vec4 xzxw { get { return new vec4(x, z, x, w); } set { x = value.x; z = value.y; x = value.z; w = value.w; } }
        public vec4 xzyx { get { return new vec4(x, z, y, x); } set { x = value.x; z = value.y; y = value.z; x = value.w; } }
        public vec4 xzyy { get { return new vec4(x, z, y, y); } set { x = value.x; z = value.y; y = value.z; y = value.w; } }
        public vec4 xzyz { get { return new vec4(x, z, y, z); } set { x = value.x; z = value.y; y = value.z; z = value.w; } }
        public vec4 xzzx { get { return new vec4(x, z, z, x); } set { x = value.x; z = value.y; z = value.z; x = value.w; } }
        public vec4 xzzy { get { return new vec4(x, z, z, y); } set { x = value.x; z = value.y; z = value.z; y = value.w; } }
        public vec4 xzzz { get { return new vec4(x, z, z, z); } set { x = value.x; z = value.y; z = value.z; z = value.w; } }
        public vec4 xzzw { get { return new vec4(x, z, z, w); } set { x = value.x; z = value.y; z = value.z; w = value.w; } }
        public vec4 xzwx { get { return new vec4(x, z, w, x); } set { x = value.x; z = value.y; w = value.z; x = value.w; } }
        public vec4 xzwz { get { return new vec4(x, z, w, z); } set { x = value.x; z = value.y; w = value.z; z = value.w; } }
        public vec4 xzww { get { return new vec4(x, z, w, w); } set { x = value.x; z = value.y; w = value.z; w = value.w; } }
        public vec4 xwxx { get { return new vec4(x, w, x, x); } set { x = value.x; w = value.y; x = value.z; x = value.w; } }
        public vec4 xwxy { get { return new vec4(x, w, x, y); } set { x = value.x; w = value.y; x = value.z; y = value.w; } }
        public vec4 xwxz { get { return new vec4(x, w, x, z); } set { x = value.x; w = value.y; x = value.z; z = value.w; } }
        public vec4 xwxw { get { return new vec4(x, w, x, w); } set { x = value.x; w = value.y; x = value.z; w = value.w; } }
        public vec4 xwyx { get { return new vec4(x, w, y, x); } set { x = value.x; w = value.y; y = value.z; x = value.w; } }
        public vec4 xwyy { get { return new vec4(x, w, y, y); } set { x = value.x; w = value.y; y = value.z; y = value.w; } }
        public vec4 xwyw { get { return new vec4(x, w, y, w); } set { x = value.x; w = value.y; y = value.z; w = value.w; } }
        public vec4 xwzx { get { return new vec4(x, w, z, x); } set { x = value.x; w = value.y; z = value.z; x = value.w; } }
        public vec4 xwzz { get { return new vec4(x, w, z, z); } set { x = value.x; w = value.y; z = value.z; z = value.w; } }
        public vec4 xwzw { get { return new vec4(x, w, z, w); } set { x = value.x; w = value.y; z = value.z; w = value.w; } }
        public vec4 xwwx { get { return new vec4(x, w, w, x); } set { x = value.x; w = value.y; w = value.z; x = value.w; } }
        public vec4 xwwy { get { return new vec4(x, w, w, y); } set { x = value.x; w = value.y; w = value.z; y = value.w; } }
        public vec4 xwwz { get { return new vec4(x, w, w, z); } set { x = value.x; w = value.y; w = value.z; z = value.w; } }
        public vec4 xwww { get { return new vec4(x, w, w, w); } set { x = value.x; w = value.y; w = value.z; w = value.w; } }
        public vec4 yxxx { get { return new vec4(y, x, x, x); } set { y = value.x; x = value.y; x = value.z; x = value.w; } }
        public vec4 yxxy { get { return new vec4(y, x, x, y); } set { y = value.x; x = value.y; x = value.z; y = value.w; } }
        public vec4 yxxz { get { return new vec4(y, x, x, z); } set { y = value.x; x = value.y; x = value.z; z = value.w; } }
        public vec4 yxxw { get { return new vec4(y, x, x, w); } set { y = value.x; x = value.y; x = value.z; w = value.w; } }
        public vec4 yxyx { get { return new vec4(y, x, y, x); } set { y = value.x; x = value.y; y = value.z; x = value.w; } }
        public vec4 yxyy { get { return new vec4(y, x, y, y); } set { y = value.x; x = value.y; y = value.z; y = value.w; } }
        public vec4 yxyz { get { return new vec4(y, x, y, z); } set { y = value.x; x = value.y; y = value.z; z = value.w; } }
        public vec4 yxyw { get { return new vec4(y, x, y, w); } set { y = value.x; x = value.y; y = value.z; w = value.w; } }
        public vec4 yxzx { get { return new vec4(y, x, z, x); } set { y = value.x; x = value.y; z = value.z; x = value.w; } }
        public vec4 yxzy { get { return new vec4(y, x, z, y); } set { y = value.x; x = value.y; z = value.z; y = value.w; } }
        public vec4 yxzz { get { return new vec4(y, x, z, z); } set { y = value.x; x = value.y; z = value.z; z = value.w; } }
        public vec4 yxwx { get { return new vec4(y, x, w, x); } set { y = value.x; x = value.y; w = value.z; x = value.w; } }
        public vec4 yxwy { get { return new vec4(y, x, w, y); } set { y = value.x; x = value.y; w = value.z; y = value.w; } }
        public vec4 yxww { get { return new vec4(y, x, w, w); } set { y = value.x; x = value.y; w = value.z; w = value.w; } }
        public vec4 yyxx { get { return new vec4(y, y, x, x); } set { y = value.x; y = value.y; x = value.z; x = value.w; } }
        public vec4 yyxy { get { return new vec4(y, y, x, y); } set { y = value.x; y = value.y; x = value.z; y = value.w; } }
        public vec4 yyxz { get { return new vec4(y, y, x, z); } set { y = value.x; y = value.y; x = value.z; z = value.w; } }
        public vec4 yyxw { get { return new vec4(y, y, x, w); } set { y = value.x; y = value.y; x = value.z; w = value.w; } }
        public vec4 yyyx { get { return new vec4(y, y, y, x); } set { y = value.x; y = value.y; y = value.z; x = value.w; } }
        public vec4 yyyy { get { return new vec4(y, y, y, y); } set { y = value.x; y = value.y; y = value.z; y = value.w; } }
        public vec4 yyyz { get { return new vec4(y, y, y, z); } set { y = value.x; y = value.y; y = value.z; z = value.w; } }
        public vec4 yyyw { get { return new vec4(y, y, y, w); } set { y = value.x; y = value.y; y = value.z; w = value.w; } }
        public vec4 yyzx { get { return new vec4(y, y, z, x); } set { y = value.x; y = value.y; z = value.z; x = value.w; } }
        public vec4 yyzy { get { return new vec4(y, y, z, y); } set { y = value.x; y = value.y; z = value.z; y = value.w; } }
        public vec4 yyzz { get { return new vec4(y, y, z, z); } set { y = value.x; y = value.y; z = value.z; z = value.w; } }
        public vec4 yyzw { get { return new vec4(y, y, z, w); } set { y = value.x; y = value.y; z = value.z; w = value.w; } }
        public vec4 yywx { get { return new vec4(y, y, w, x); } set { y = value.x; y = value.y; w = value.z; x = value.w; } }
        public vec4 yywy { get { return new vec4(y, y, w, y); } set { y = value.x; y = value.y; w = value.z; y = value.w; } }
        public vec4 yywz { get { return new vec4(y, y, w, z); } set { y = value.x; y = value.y; w = value.z; z = value.w; } }
        public vec4 yyww { get { return new vec4(y, y, w, w); } set { y = value.x; y = value.y; w = value.z; w = value.w; } }
        public vec4 yzxx { get { return new vec4(y, z, x, x); } set { y = value.x; z = value.y; x = value.z; x = value.w; } }
        public vec4 yzxy { get { return new vec4(y, z, x, y); } set { y = value.x; z = value.y; x = value.z; y = value.w; } }
        public vec4 yzxz { get { return new vec4(y, z, x, z); } set { y = value.x; z = value.y; x = value.z; z = value.w; } }
        public vec4 yzyx { get { return new vec4(y, z, y, x); } set { y = value.x; z = value.y; y = value.z; x = value.w; } }
        public vec4 yzyy { get { return new vec4(y, z, y, y); } set { y = value.x; z = value.y; y = value.z; y = value.w; } }
        public vec4 yzyz { get { return new vec4(y, z, y, z); } set { y = value.x; z = value.y; y = value.z; z = value.w; } }
        public vec4 yzyw { get { return new vec4(y, z, y, w); } set { y = value.x; z = value.y; y = value.z; w = value.w; } }
        public vec4 yzzx { get { return new vec4(y, z, z, x); } set { y = value.x; z = value.y; z = value.z; x = value.w; } }
        public vec4 yzzy { get { return new vec4(y, z, z, y); } set { y = value.x; z = value.y; z = value.z; y = value.w; } }
        public vec4 yzzz { get { return new vec4(y, z, z, z); } set { y = value.x; z = value.y; z = value.z; z = value.w; } }
        public vec4 yzzw { get { return new vec4(y, z, z, w); } set { y = value.x; z = value.y; z = value.z; w = value.w; } }
        public vec4 yzwy { get { return new vec4(y, z, w, y); } set { y = value.x; z = value.y; w = value.z; y = value.w; } }
        public vec4 yzwz { get { return new vec4(y, z, w, z); } set { y = value.x; z = value.y; w = value.z; z = value.w; } }
        public vec4 yzww { get { return new vec4(y, z, w, w); } set { y = value.x; z = value.y; w = value.z; w = value.w; } }
        public vec4 ywxx { get { return new vec4(y, w, x, x); } set { y = value.x; w = value.y; x = value.z; x = value.w; } }
        public vec4 ywxy { get { return new vec4(y, w, x, y); } set { y = value.x; w = value.y; x = value.z; y = value.w; } }
        public vec4 ywxw { get { return new vec4(y, w, x, w); } set { y = value.x; w = value.y; x = value.z; w = value.w; } }
        public vec4 ywyx { get { return new vec4(y, w, y, x); } set { y = value.x; w = value.y; y = value.z; x = value.w; } }
        public vec4 ywyy { get { return new vec4(y, w, y, y); } set { y = value.x; w = value.y; y = value.z; y = value.w; } }
        public vec4 ywyz { get { return new vec4(y, w, y, z); } set { y = value.x; w = value.y; y = value.z; z = value.w; } }
        public vec4 ywyw { get { return new vec4(y, w, y, w); } set { y = value.x; w = value.y; y = value.z; w = value.w; } }
        public vec4 ywzy { get { return new vec4(y, w, z, y); } set { y = value.x; w = value.y; z = value.z; y = value.w; } }
        public vec4 ywzz { get { return new vec4(y, w, z, z); } set { y = value.x; w = value.y; z = value.z; z = value.w; } }
        public vec4 ywzw { get { return new vec4(y, w, z, w); } set { y = value.x; w = value.y; z = value.z; w = value.w; } }
        public vec4 ywwx { get { return new vec4(y, w, w, x); } set { y = value.x; w = value.y; w = value.z; x = value.w; } }
        public vec4 ywwy { get { return new vec4(y, w, w, y); } set { y = value.x; w = value.y; w = value.z; y = value.w; } }
        public vec4 ywwz { get { return new vec4(y, w, w, z); } set { y = value.x; w = value.y; w = value.z; z = value.w; } }
        public vec4 ywww { get { return new vec4(y, w, w, w); } set { y = value.x; w = value.y; w = value.z; w = value.w; } }
        public vec4 zxxx { get { return new vec4(z, x, x, x); } set { z = value.x; x = value.y; x = value.z; x = value.w; } }
        public vec4 zxxy { get { return new vec4(z, x, x, y); } set { z = value.x; x = value.y; x = value.z; y = value.w; } }
        public vec4 zxxz { get { return new vec4(z, x, x, z); } set { z = value.x; x = value.y; x = value.z; z = value.w; } }
        public vec4 zxxw { get { return new vec4(z, x, x, w); } set { z = value.x; x = value.y; x = value.z; w = value.w; } }
        public vec4 zxyx { get { return new vec4(z, x, y, x); } set { z = value.x; x = value.y; y = value.z; x = value.w; } }
        public vec4 zxyy { get { return new vec4(z, x, y, y); } set { z = value.x; x = value.y; y = value.z; y = value.w; } }
        public vec4 zxyz { get { return new vec4(z, x, y, z); } set { z = value.x; x = value.y; y = value.z; z = value.w; } }
        public vec4 zxzx { get { return new vec4(z, x, z, x); } set { z = value.x; x = value.y; z = value.z; x = value.w; } }
        public vec4 zxzy { get { return new vec4(z, x, z, y); } set { z = value.x; x = value.y; z = value.z; y = value.w; } }
        public vec4 zxzz { get { return new vec4(z, x, z, z); } set { z = value.x; x = value.y; z = value.z; z = value.w; } }
        public vec4 zxzw { get { return new vec4(z, x, z, w); } set { z = value.x; x = value.y; z = value.z; w = value.w; } }
        public vec4 zxwx { get { return new vec4(z, x, w, x); } set { z = value.x; x = value.y; w = value.z; x = value.w; } }
        public vec4 zxwz { get { return new vec4(z, x, w, z); } set { z = value.x; x = value.y; w = value.z; z = value.w; } }
        public vec4 zxww { get { return new vec4(z, x, w, w); } set { z = value.x; x = value.y; w = value.z; w = value.w; } }
        public vec4 zyxx { get { return new vec4(z, y, x, x); } set { z = value.x; y = value.y; x = value.z; x = value.w; } }
        public vec4 zyxy { get { return new vec4(z, y, x, y); } set { z = value.x; y = value.y; x = value.z; y = value.w; } }
        public vec4 zyxz { get { return new vec4(z, y, x, z); } set { z = value.x; y = value.y; x = value.z; z = value.w; } }
        public vec4 zyyx { get { return new vec4(z, y, y, x); } set { z = value.x; y = value.y; y = value.z; x = value.w; } }
        public vec4 zyyy { get { return new vec4(z, y, y, y); } set { z = value.x; y = value.y; y = value.z; y = value.w; } }
        public vec4 zyyz { get { return new vec4(z, y, y, z); } set { z = value.x; y = value.y; y = value.z; z = value.w; } }
        public vec4 zyyw { get { return new vec4(z, y, y, w); } set { z = value.x; y = value.y; y = value.z; w = value.w; } }
        public vec4 zyzx { get { return new vec4(z, y, z, x); } set { z = value.x; y = value.y; z = value.z; x = value.w; } }
        public vec4 zyzy { get { return new vec4(z, y, z, y); } set { z = value.x; y = value.y; z = value.z; y = value.w; } }
        public vec4 zyzz { get { return new vec4(z, y, z, z); } set { z = value.x; y = value.y; z = value.z; z = value.w; } }
        public vec4 zyzw { get { return new vec4(z, y, z, w); } set { z = value.x; y = value.y; z = value.z; w = value.w; } }
        public vec4 zywy { get { return new vec4(z, y, w, y); } set { z = value.x; y = value.y; w = value.z; y = value.w; } }
        public vec4 zywz { get { return new vec4(z, y, w, z); } set { z = value.x; y = value.y; w = value.z; z = value.w; } }
        public vec4 zyww { get { return new vec4(z, y, w, w); } set { z = value.x; y = value.y; w = value.z; w = value.w; } }
        public vec4 zzxx { get { return new vec4(z, z, x, x); } set { z = value.x; z = value.y; x = value.z; x = value.w; } }
        public vec4 zzxy { get { return new vec4(z, z, x, y); } set { z = value.x; z = value.y; x = value.z; y = value.w; } }
        public vec4 zzxz { get { return new vec4(z, z, x, z); } set { z = value.x; z = value.y; x = value.z; z = value.w; } }
        public vec4 zzxw { get { return new vec4(z, z, x, w); } set { z = value.x; z = value.y; x = value.z; w = value.w; } }
        public vec4 zzyx { get { return new vec4(z, z, y, x); } set { z = value.x; z = value.y; y = value.z; x = value.w; } }
        public vec4 zzyy { get { return new vec4(z, z, y, y); } set { z = value.x; z = value.y; y = value.z; y = value.w; } }
        public vec4 zzyz { get { return new vec4(z, z, y, z); } set { z = value.x; z = value.y; y = value.z; z = value.w; } }
        public vec4 zzyw { get { return new vec4(z, z, y, w); } set { z = value.x; z = value.y; y = value.z; w = value.w; } }
        public vec4 zzzx { get { return new vec4(z, z, z, x); } set { z = value.x; z = value.y; z = value.z; x = value.w; } }
        public vec4 zzzy { get { return new vec4(z, z, z, y); } set { z = value.x; z = value.y; z = value.z; y = value.w; } }
        public vec4 zzzz { get { return new vec4(z, z, z, z); } set { z = value.x; z = value.y; z = value.z; z = value.w; } }
        public vec4 zzzw { get { return new vec4(z, z, z, w); } set { z = value.x; z = value.y; z = value.z; w = value.w; } }
        public vec4 zzwx { get { return new vec4(z, z, w, x); } set { z = value.x; z = value.y; w = value.z; x = value.w; } }
        public vec4 zzwy { get { return new vec4(z, z, w, y); } set { z = value.x; z = value.y; w = value.z; y = value.w; } }
        public vec4 zzwz { get { return new vec4(z, z, w, z); } set { z = value.x; z = value.y; w = value.z; z = value.w; } }
        public vec4 zzww { get { return new vec4(z, z, w, w); } set { z = value.x; z = value.y; w = value.z; w = value.w; } }
        public vec4 zwxx { get { return new vec4(z, w, x, x); } set { z = value.x; w = value.y; x = value.z; x = value.w; } }
        public vec4 zwxz { get { return new vec4(z, w, x, z); } set { z = value.x; w = value.y; x = value.z; z = value.w; } }
        public vec4 zwxw { get { return new vec4(z, w, x, w); } set { z = value.x; w = value.y; x = value.z; w = value.w; } }
        public vec4 zwyy { get { return new vec4(z, w, y, y); } set { z = value.x; w = value.y; y = value.z; y = value.w; } }
        public vec4 zwyz { get { return new vec4(z, w, y, z); } set { z = value.x; w = value.y; y = value.z; z = value.w; } }
        public vec4 zwyw { get { return new vec4(z, w, y, w); } set { z = value.x; w = value.y; y = value.z; w = value.w; } }
        public vec4 zwzx { get { return new vec4(z, w, z, x); } set { z = value.x; w = value.y; z = value.z; x = value.w; } }
        public vec4 zwzy { get { return new vec4(z, w, z, y); } set { z = value.x; w = value.y; z = value.z; y = value.w; } }
        public vec4 zwzz { get { return new vec4(z, w, z, z); } set { z = value.x; w = value.y; z = value.z; z = value.w; } }
        public vec4 zwzw { get { return new vec4(z, w, z, w); } set { z = value.x; w = value.y; z = value.z; w = value.w; } }
        public vec4 zwwx { get { return new vec4(z, w, w, x); } set { z = value.x; w = value.y; w = value.z; x = value.w; } }
        public vec4 zwwy { get { return new vec4(z, w, w, y); } set { z = value.x; w = value.y; w = value.z; y = value.w; } }
        public vec4 zwwz { get { return new vec4(z, w, w, z); } set { z = value.x; w = value.y; w = value.z; z = value.w; } }
        public vec4 zwww { get { return new vec4(z, w, w, w); } set { z = value.x; w = value.y; w = value.z; w = value.w; } }
        public vec4 wxxx { get { return new vec4(w, x, x, x); } set { w = value.x; x = value.y; x = value.z; x = value.w; } }
        public vec4 wxxy { get { return new vec4(w, x, x, y); } set { w = value.x; x = value.y; x = value.z; y = value.w; } }
        public vec4 wxxz { get { return new vec4(w, x, x, z); } set { w = value.x; x = value.y; x = value.z; z = value.w; } }
        public vec4 wxxw { get { return new vec4(w, x, x, w); } set { w = value.x; x = value.y; x = value.z; w = value.w; } }
        public vec4 wxyx { get { return new vec4(w, x, y, x); } set { w = value.x; x = value.y; y = value.z; x = value.w; } }
        public vec4 wxyy { get { return new vec4(w, x, y, y); } set { w = value.x; x = value.y; y = value.z; y = value.w; } }
        public vec4 wxyw { get { return new vec4(w, x, y, w); } set { w = value.x; x = value.y; y = value.z; w = value.w; } }
        public vec4 wxzx { get { return new vec4(w, x, z, x); } set { w = value.x; x = value.y; z = value.z; x = value.w; } }
        public vec4 wxzz { get { return new vec4(w, x, z, z); } set { w = value.x; x = value.y; z = value.z; z = value.w; } }
        public vec4 wxzw { get { return new vec4(w, x, z, w); } set { w = value.x; x = value.y; z = value.z; w = value.w; } }
        public vec4 wxwx { get { return new vec4(w, x, w, x); } set { w = value.x; x = value.y; w = value.z; x = value.w; } }
        public vec4 wxwy { get { return new vec4(w, x, w, y); } set { w = value.x; x = value.y; w = value.z; y = value.w; } }
        public vec4 wxwz { get { return new vec4(w, x, w, z); } set { w = value.x; x = value.y; w = value.z; z = value.w; } }
        public vec4 wxww { get { return new vec4(w, x, w, w); } set { w = value.x; x = value.y; w = value.z; w = value.w; } }
        public vec4 wyxx { get { return new vec4(w, y, x, x); } set { w = value.x; y = value.y; x = value.z; x = value.w; } }
        public vec4 wyxy { get { return new vec4(w, y, x, y); } set { w = value.x; y = value.y; x = value.z; y = value.w; } }
        public vec4 wyxw { get { return new vec4(w, y, x, w); } set { w = value.x; y = value.y; x = value.z; w = value.w; } }
        public vec4 wyyx { get { return new vec4(w, y, y, x); } set { w = value.x; y = value.y; y = value.z; x = value.w; } }
        public vec4 wyyy { get { return new vec4(w, y, y, y); } set { w = value.x; y = value.y; y = value.z; y = value.w; } }
        public vec4 wyyz { get { return new vec4(w, y, y, z); } set { w = value.x; y = value.y; y = value.z; z = value.w; } }
        public vec4 wyyw { get { return new vec4(w, y, y, w); } set { w = value.x; y = value.y; y = value.z; w = value.w; } }
        public vec4 wyzy { get { return new vec4(w, y, z, y); } set { w = value.x; y = value.y; z = value.z; y = value.w; } }
        public vec4 wyzz { get { return new vec4(w, y, z, z); } set { w = value.x; y = value.y; z = value.z; z = value.w; } }
        public vec4 wyzw { get { return new vec4(w, y, z, w); } set { w = value.x; y = value.y; z = value.z; w = value.w; } }
        public vec4 wywx { get { return new vec4(w, y, w, x); } set { w = value.x; y = value.y; w = value.z; x = value.w; } }
        public vec4 wywy { get { return new vec4(w, y, w, y); } set { w = value.x; y = value.y; w = value.z; y = value.w; } }
        public vec4 wywz { get { return new vec4(w, y, w, z); } set { w = value.x; y = value.y; w = value.z; z = value.w; } }
        public vec4 wyww { get { return new vec4(w, y, w, w); } set { w = value.x; y = value.y; w = value.z; w = value.w; } }
        public vec4 wzxx { get { return new vec4(w, z, x, x); } set { w = value.x; z = value.y; x = value.z; x = value.w; } }
        public vec4 wzxz { get { return new vec4(w, z, x, z); } set { w = value.x; z = value.y; x = value.z; z = value.w; } }
        public vec4 wzxw { get { return new vec4(w, z, x, w); } set { w = value.x; z = value.y; x = value.z; w = value.w; } }
        public vec4 wzyy { get { return new vec4(w, z, y, y); } set { w = value.x; z = value.y; y = value.z; y = value.w; } }
        public vec4 wzyz { get { return new vec4(w, z, y, z); } set { w = value.x; z = value.y; y = value.z; z = value.w; } }
        public vec4 wzyw { get { return new vec4(w, z, y, w); } set { w = value.x; z = value.y; y = value.z; w = value.w; } }
        public vec4 wzzx { get { return new vec4(w, z, z, x); } set { w = value.x; z = value.y; z = value.z; x = value.w; } }
        public vec4 wzzy { get { return new vec4(w, z, z, y); } set { w = value.x; z = value.y; z = value.z; y = value.w; } }
        public vec4 wzzz { get { return new vec4(w, z, z, z); } set { w = value.x; z = value.y; z = value.z; z = value.w; } }
        public vec4 wzzw { get { return new vec4(w, z, z, w); } set { w = value.x; z = value.y; z = value.z; w = value.w; } }
        public vec4 wzwx { get { return new vec4(w, z, w, x); } set { w = value.x; z = value.y; w = value.z; x = value.w; } }
        public vec4 wzwy { get { return new vec4(w, z, w, y); } set { w = value.x; z = value.y; w = value.z; y = value.w; } }
        public vec4 wzwz { get { return new vec4(w, z, w, z); } set { w = value.x; z = value.y; w = value.z; z = value.w; } }
        public vec4 wzww { get { return new vec4(w, z, w, w); } set { w = value.x; z = value.y; w = value.z; w = value.w; } }
        public vec4 wwxx { get { return new vec4(w, w, x, x); } set { w = value.x; w = value.y; x = value.z; x = value.w; } }
        public vec4 wwxy { get { return new vec4(w, w, x, y); } set { w = value.x; w = value.y; x = value.z; y = value.w; } }
        public vec4 wwxz { get { return new vec4(w, w, x, z); } set { w = value.x; w = value.y; x = value.z; z = value.w; } }
        public vec4 wwxw { get { return new vec4(w, w, x, w); } set { w = value.x; w = value.y; x = value.z; w = value.w; } }
        public vec4 wwyx { get { return new vec4(w, w, y, x); } set { w = value.x; w = value.y; y = value.z; x = value.w; } }
        public vec4 wwyy { get { return new vec4(w, w, y, y); } set { w = value.x; w = value.y; y = value.z; y = value.w; } }
        public vec4 wwyz { get { return new vec4(w, w, y, z); } set { w = value.x; w = value.y; y = value.z; z = value.w; } }
        public vec4 wwyw { get { return new vec4(w, w, y, w); } set { w = value.x; w = value.y; y = value.z; w = value.w; } }
        public vec4 wwzx { get { return new vec4(w, w, z, x); } set { w = value.x; w = value.y; z = value.z; x = value.w; } }
        public vec4 wwzy { get { return new vec4(w, w, z, y); } set { w = value.x; w = value.y; z = value.z; y = value.w; } }
        public vec4 wwzz { get { return new vec4(w, w, z, z); } set { w = value.x; w = value.y; z = value.z; z = value.w; } }
        public vec4 wwzw { get { return new vec4(w, w, z, w); } set { w = value.x; w = value.y; z = value.z; w = value.w; } }
        public vec4 wwwx { get { return new vec4(w, w, w, x); } set { w = value.x; w = value.y; w = value.z; x = value.w; } }
        public vec4 wwwy { get { return new vec4(w, w, w, y); } set { w = value.x; w = value.y; w = value.z; y = value.w; } }
        public vec4 wwwz { get { return new vec4(w, w, w, z); } set { w = value.x; w = value.y; w = value.z; z = value.w; } }
        public vec4 wwww { get { return new vec4(w, w, w, w); } set { w = value.x; w = value.y; w = value.z; w = value.w; } }
#endif

#endif
#if COLOURS_ENABLED
#if CAPITALS_ENABLED
        public float A
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
        public float a
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

        public vec4 rgba
        {
            get
            {
                return new vec4(r, g, b, a);
            }
            set
            {
                r = value.r;
                g = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public vec4 rabg
        {
            get
            {
                return new vec4(r, a, b, g);
            }
            set
            {
                r = value.r;
                a = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public vec4 ragb
        {
            get
            {
                return new vec4(r, a, g, b);
            }
            set
            {
                r = value.r;
                a = value.g;
                g = value.b;
                b = value.a;
            }
        }
        public vec4 rgab
        {
            get
            {
                return new vec4(r, g, a, b);
            }
            set
            {
                r = value.r;
                g = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public vec4 rbga
        {
            get
            {
                return new vec4(r, b, g, a);
            }
            set
            {
                r = value.r;
                b = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public vec4 rbag
        {
            get
            {
                return new vec4(r, b, a, g);
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

        public vec4 grba
        {
            get
            {
                return new vec4(g, r, b, a);
            }
            set
            {
                g = value.r;
                r = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public vec4 grab
        {
            get
            {
                return new vec4(g, r, a, b);
            }
            set
            {
                g = value.r;
                r = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public vec4 gbra
        {
            get
            {
                return new vec4(g, b, r, a);
            }
            set
            {
                g = value.r;
                b = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public vec4 gbar
        {
            get
            {
                return new vec4(g, b, a, r);
            }
            set
            {
                g = value.r;
                b = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public vec4 gabr
        {
            get
            {
                return new vec4(g, a, b, r);
            }
            set
            {
                g = value.r;
                a = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public vec4 garb
        {
            get
            {
                return new vec4(g, a, r, b);
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

        public vec4 brga
        {
            get
            {
                return new vec4(b, r, g, a);
            }
            set
            {
                b = value.r;
                r = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public vec4 bgra
        {
            get
            {
                return new vec4(b, g, r, a);
            }
            set
            {
                b = value.r;
                g = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public vec4 bgar
        {
            get
            {
                return new vec4(b, g, a, r);
            }
            set
            {
                b = value.r;
                g = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public vec4 brag
        {
            get
            {
                return new vec4(b, r, a, g);
            }
            set
            {
                b = value.r;
                r = value.g;
                a = value.b;
                g = value.a;
            }
        }
        public vec4 barg
        {
            get
            {
                return new vec4(b, a, r, g);
            }
            set
            {
                b = value.r;
                a = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public vec4 bagr
        {
            get
            {
                return new vec4(b, a, g, r);
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

        public vec4 argb
        {
            get
            {
                return new vec4(a, r, g, b);
            }
            set
            {
                a = value.r;
                r = value.g;
                g = value.b;
                b = value.a;
            }
        }

        public vec4 arbg
        {
            get
            {
                return new vec4(a, r, b, g);
            }
            set
            {
                a = value.r;
                r = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public vec4 agrb
        {
            get
            {
                return new vec4(a, g, r, b);
            }
            set
            {
                a = value.r;
                g = value.g;
                r = value.b;
                b = value.a;
            }
        }
        public vec4 agbr
        {
            get
            {
                return new vec4(a, g, b, r);
            }
            set
            {
                a = value.r;
                g = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public vec4 abrg
        {
            get
            {
                return new vec4(a, b, r, g);
            }
            set
            {
                a = value.r;
                b = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public vec4 abgr
        {
            get
            {
                return new vec4(a, b, g, r);
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
        public vec2 aa
        {
            get { return new vec2(a, a); }
            set { a = value.r; a = value.g; }
        }

        // vec4 color duplicates
        public vec4 rrrr { get { return new vec4(r, r, r, r); } set { r = value.r; r = value.g; r = value.b; r = value.a; } }
        public vec4 rrrg { get { return new vec4(r, r, r, g); } set { r = value.r; r = value.g; r = value.b; g = value.a; } }
        public vec4 rrrb { get { return new vec4(r, r, r, b); } set { r = value.r; r = value.g; r = value.b; b = value.a; } }
        public vec4 rrra { get { return new vec4(r, r, r, a); } set { r = value.r; r = value.g; r = value.b; a = value.a; } }
        public vec4 rrgr { get { return new vec4(r, r, g, r); } set { r = value.r; r = value.g; g = value.b; r = value.a; } }
        public vec4 rrgg { get { return new vec4(r, r, g, g); } set { r = value.r; r = value.g; g = value.b; g = value.a; } }
        public vec4 rrgb { get { return new vec4(r, r, g, b); } set { r = value.r; r = value.g; g = value.b; b = value.a; } }
        public vec4 rrga { get { return new vec4(r, r, g, a); } set { r = value.r; r = value.g; g = value.b; a = value.a; } }
        public vec4 rrbr { get { return new vec4(r, r, b, r); } set { r = value.r; r = value.g; b = value.b; r = value.a; } }
        public vec4 rrbg { get { return new vec4(r, r, b, g); } set { r = value.r; r = value.g; b = value.b; g = value.a; } }
        public vec4 rrbb { get { return new vec4(r, r, b, b); } set { r = value.r; r = value.g; b = value.b; b = value.a; } }
        public vec4 rrba { get { return new vec4(r, r, b, a); } set { r = value.r; r = value.g; b = value.b; a = value.a; } }
        public vec4 rrar { get { return new vec4(r, r, a, r); } set { r = value.r; r = value.g; a = value.b; r = value.a; } }
        public vec4 rrag { get { return new vec4(r, r, a, g); } set { r = value.r; r = value.g; a = value.b; g = value.a; } }
        public vec4 rrab { get { return new vec4(r, r, a, b); } set { r = value.r; r = value.g; a = value.b; b = value.a; } }
        public vec4 rraa { get { return new vec4(r, r, a, a); } set { r = value.r; r = value.g; a = value.b; a = value.a; } }
        public vec4 rgrr { get { return new vec4(r, g, r, r); } set { r = value.r; g = value.g; r = value.b; r = value.a; } }
        public vec4 rgrg { get { return new vec4(r, g, r, g); } set { r = value.r; g = value.g; r = value.b; g = value.a; } }
        public vec4 rgrb { get { return new vec4(r, g, r, b); } set { r = value.r; g = value.g; r = value.b; b = value.a; } }
        public vec4 rgra { get { return new vec4(r, g, r, a); } set { r = value.r; g = value.g; r = value.b; a = value.a; } }
        public vec4 rggr { get { return new vec4(r, g, g, r); } set { r = value.r; g = value.g; g = value.b; r = value.a; } }
        public vec4 rggg { get { return new vec4(r, g, g, g); } set { r = value.r; g = value.g; g = value.b; g = value.a; } }
        public vec4 rggb { get { return new vec4(r, g, g, b); } set { r = value.r; g = value.g; g = value.b; b = value.a; } }
        public vec4 rgga { get { return new vec4(r, g, g, a); } set { r = value.r; g = value.g; g = value.b; a = value.a; } }
        public vec4 rgbr { get { return new vec4(r, g, b, r); } set { r = value.r; g = value.g; b = value.b; r = value.a; } }
        public vec4 rgbg { get { return new vec4(r, g, b, g); } set { r = value.r; g = value.g; b = value.b; g = value.a; } }
        public vec4 rgbb { get { return new vec4(r, g, b, b); } set { r = value.r; g = value.g; b = value.b; b = value.a; } }
        public vec4 rgar { get { return new vec4(r, g, a, r); } set { r = value.r; g = value.g; a = value.b; r = value.a; } }
        public vec4 rgag { get { return new vec4(r, g, a, g); } set { r = value.r; g = value.g; a = value.b; g = value.a; } }
        public vec4 rgaa { get { return new vec4(r, g, a, a); } set { r = value.r; g = value.g; a = value.b; a = value.a; } }
        public vec4 rbrr { get { return new vec4(r, b, r, r); } set { r = value.r; b = value.g; r = value.b; r = value.a; } }
        public vec4 rbrg { get { return new vec4(r, b, r, g); } set { r = value.r; b = value.g; r = value.b; g = value.a; } }
        public vec4 rbrb { get { return new vec4(r, b, r, b); } set { r = value.r; b = value.g; r = value.b; b = value.a; } }
        public vec4 rbra { get { return new vec4(r, b, r, a); } set { r = value.r; b = value.g; r = value.b; a = value.a; } }
        public vec4 rbgr { get { return new vec4(r, b, g, r); } set { r = value.r; b = value.g; g = value.b; r = value.a; } }
        public vec4 rbgg { get { return new vec4(r, b, g, g); } set { r = value.r; b = value.g; g = value.b; g = value.a; } }
        public vec4 rbgb { get { return new vec4(r, b, g, b); } set { r = value.r; b = value.g; g = value.b; b = value.a; } }
        public vec4 rbbr { get { return new vec4(r, b, b, r); } set { r = value.r; b = value.g; b = value.b; r = value.a; } }
        public vec4 rbbg { get { return new vec4(r, b, b, g); } set { r = value.r; b = value.g; b = value.b; g = value.a; } }
        public vec4 rbbb { get { return new vec4(r, b, b, b); } set { r = value.r; b = value.g; b = value.b; b = value.a; } }
        public vec4 rbba { get { return new vec4(r, b, b, a); } set { r = value.r; b = value.g; b = value.b; a = value.a; } }
        public vec4 rbar { get { return new vec4(r, b, a, r); } set { r = value.r; b = value.g; a = value.b; r = value.a; } }
        public vec4 rbab { get { return new vec4(r, b, a, b); } set { r = value.r; b = value.g; a = value.b; b = value.a; } }
        public vec4 rbaa { get { return new vec4(r, b, a, a); } set { r = value.r; b = value.g; a = value.b; a = value.a; } }
        public vec4 rarr { get { return new vec4(r, a, r, r); } set { r = value.r; a = value.g; r = value.b; r = value.a; } }
        public vec4 rarg { get { return new vec4(r, a, r, g); } set { r = value.r; a = value.g; r = value.b; g = value.a; } }
        public vec4 rarb { get { return new vec4(r, a, r, b); } set { r = value.r; a = value.g; r = value.b; b = value.a; } }
        public vec4 rara { get { return new vec4(r, a, r, a); } set { r = value.r; a = value.g; r = value.b; a = value.a; } }
        public vec4 ragr { get { return new vec4(r, a, g, r); } set { r = value.r; a = value.g; g = value.b; r = value.a; } }
        public vec4 ragg { get { return new vec4(r, a, g, g); } set { r = value.r; a = value.g; g = value.b; g = value.a; } }
        public vec4 raga { get { return new vec4(r, a, g, a); } set { r = value.r; a = value.g; g = value.b; a = value.a; } }
        public vec4 rabr { get { return new vec4(r, a, b, r); } set { r = value.r; a = value.g; b = value.b; r = value.a; } }
        public vec4 rabb { get { return new vec4(r, a, b, b); } set { r = value.r; a = value.g; b = value.b; b = value.a; } }
        public vec4 raba { get { return new vec4(r, a, b, a); } set { r = value.r; a = value.g; b = value.b; a = value.a; } }
        public vec4 raar { get { return new vec4(r, a, a, r); } set { r = value.r; a = value.g; a = value.b; r = value.a; } }
        public vec4 raag { get { return new vec4(r, a, a, g); } set { r = value.r; a = value.g; a = value.b; g = value.a; } }
        public vec4 raab { get { return new vec4(r, a, a, b); } set { r = value.r; a = value.g; a = value.b; b = value.a; } }
        public vec4 raaa { get { return new vec4(r, a, a, a); } set { r = value.r; a = value.g; a = value.b; a = value.a; } }
        public vec4 grrr { get { return new vec4(g, r, r, r); } set { g = value.r; r = value.g; r = value.b; r = value.a; } }
        public vec4 grrg { get { return new vec4(g, r, r, g); } set { g = value.r; r = value.g; r = value.b; g = value.a; } }
        public vec4 grrb { get { return new vec4(g, r, r, b); } set { g = value.r; r = value.g; r = value.b; b = value.a; } }
        public vec4 grra { get { return new vec4(g, r, r, a); } set { g = value.r; r = value.g; r = value.b; a = value.a; } }
        public vec4 grgr { get { return new vec4(g, r, g, r); } set { g = value.r; r = value.g; g = value.b; r = value.a; } }
        public vec4 grgg { get { return new vec4(g, r, g, g); } set { g = value.r; r = value.g; g = value.b; g = value.a; } }
        public vec4 grgb { get { return new vec4(g, r, g, b); } set { g = value.r; r = value.g; g = value.b; b = value.a; } }
        public vec4 grga { get { return new vec4(g, r, g, a); } set { g = value.r; r = value.g; g = value.b; a = value.a; } }
        public vec4 grbr { get { return new vec4(g, r, b, r); } set { g = value.r; r = value.g; b = value.b; r = value.a; } }
        public vec4 grbg { get { return new vec4(g, r, b, g); } set { g = value.r; r = value.g; b = value.b; g = value.a; } }
        public vec4 grbb { get { return new vec4(g, r, b, b); } set { g = value.r; r = value.g; b = value.b; b = value.a; } }
        public vec4 grar { get { return new vec4(g, r, a, r); } set { g = value.r; r = value.g; a = value.b; r = value.a; } }
        public vec4 grag { get { return new vec4(g, r, a, g); } set { g = value.r; r = value.g; a = value.b; g = value.a; } }
        public vec4 graa { get { return new vec4(g, r, a, a); } set { g = value.r; r = value.g; a = value.b; a = value.a; } }
        public vec4 ggrr { get { return new vec4(g, g, r, r); } set { g = value.r; g = value.g; r = value.b; r = value.a; } }
        public vec4 ggrg { get { return new vec4(g, g, r, g); } set { g = value.r; g = value.g; r = value.b; g = value.a; } }
        public vec4 ggrb { get { return new vec4(g, g, r, b); } set { g = value.r; g = value.g; r = value.b; b = value.a; } }
        public vec4 ggra { get { return new vec4(g, g, r, a); } set { g = value.r; g = value.g; r = value.b; a = value.a; } }
        public vec4 gggr { get { return new vec4(g, g, g, r); } set { g = value.r; g = value.g; g = value.b; r = value.a; } }
        public vec4 gggg { get { return new vec4(g, g, g, g); } set { g = value.r; g = value.g; g = value.b; g = value.a; } }
        public vec4 gggb { get { return new vec4(g, g, g, b); } set { g = value.r; g = value.g; g = value.b; b = value.a; } }
        public vec4 ggga { get { return new vec4(g, g, g, a); } set { g = value.r; g = value.g; g = value.b; a = value.a; } }
        public vec4 ggbr { get { return new vec4(g, g, b, r); } set { g = value.r; g = value.g; b = value.b; r = value.a; } }
        public vec4 ggbg { get { return new vec4(g, g, b, g); } set { g = value.r; g = value.g; b = value.b; g = value.a; } }
        public vec4 ggbb { get { return new vec4(g, g, b, b); } set { g = value.r; g = value.g; b = value.b; b = value.a; } }
        public vec4 ggba { get { return new vec4(g, g, b, a); } set { g = value.r; g = value.g; b = value.b; a = value.a; } }
        public vec4 ggar { get { return new vec4(g, g, a, r); } set { g = value.r; g = value.g; a = value.b; r = value.a; } }
        public vec4 ggag { get { return new vec4(g, g, a, g); } set { g = value.r; g = value.g; a = value.b; g = value.a; } }
        public vec4 ggab { get { return new vec4(g, g, a, b); } set { g = value.r; g = value.g; a = value.b; b = value.a; } }
        public vec4 ggaa { get { return new vec4(g, g, a, a); } set { g = value.r; g = value.g; a = value.b; a = value.a; } }
        public vec4 gbrr { get { return new vec4(g, b, r, r); } set { g = value.r; b = value.g; r = value.b; r = value.a; } }
        public vec4 gbrg { get { return new vec4(g, b, r, g); } set { g = value.r; b = value.g; r = value.b; g = value.a; } }
        public vec4 gbrb { get { return new vec4(g, b, r, b); } set { g = value.r; b = value.g; r = value.b; b = value.a; } }
        public vec4 gbgr { get { return new vec4(g, b, g, r); } set { g = value.r; b = value.g; g = value.b; r = value.a; } }
        public vec4 gbgg { get { return new vec4(g, b, g, g); } set { g = value.r; b = value.g; g = value.b; g = value.a; } }
        public vec4 gbgb { get { return new vec4(g, b, g, b); } set { g = value.r; b = value.g; g = value.b; b = value.a; } }
        public vec4 gbga { get { return new vec4(g, b, g, a); } set { g = value.r; b = value.g; g = value.b; a = value.a; } }
        public vec4 gbbr { get { return new vec4(g, b, b, r); } set { g = value.r; b = value.g; b = value.b; r = value.a; } }
        public vec4 gbbg { get { return new vec4(g, b, b, g); } set { g = value.r; b = value.g; b = value.b; g = value.a; } }
        public vec4 gbbb { get { return new vec4(g, b, b, b); } set { g = value.r; b = value.g; b = value.b; b = value.a; } }
        public vec4 gbba { get { return new vec4(g, b, b, a); } set { g = value.r; b = value.g; b = value.b; a = value.a; } }
        public vec4 gbag { get { return new vec4(g, b, a, g); } set { g = value.r; b = value.g; a = value.b; g = value.a; } }
        public vec4 gbab { get { return new vec4(g, b, a, b); } set { g = value.r; b = value.g; a = value.b; b = value.a; } }
        public vec4 gbaa { get { return new vec4(g, b, a, a); } set { g = value.r; b = value.g; a = value.b; a = value.a; } }
        public vec4 garr { get { return new vec4(g, a, r, r); } set { g = value.r; a = value.g; r = value.b; r = value.a; } }
        public vec4 garg { get { return new vec4(g, a, r, g); } set { g = value.r; a = value.g; r = value.b; g = value.a; } }
        public vec4 gara { get { return new vec4(g, a, r, a); } set { g = value.r; a = value.g; r = value.b; a = value.a; } }
        public vec4 gagr { get { return new vec4(g, a, g, r); } set { g = value.r; a = value.g; g = value.b; r = value.a; } }
        public vec4 gagg { get { return new vec4(g, a, g, g); } set { g = value.r; a = value.g; g = value.b; g = value.a; } }
        public vec4 gagb { get { return new vec4(g, a, g, b); } set { g = value.r; a = value.g; g = value.b; b = value.a; } }
        public vec4 gaga { get { return new vec4(g, a, g, a); } set { g = value.r; a = value.g; g = value.b; a = value.a; } }
        public vec4 gabg { get { return new vec4(g, a, b, g); } set { g = value.r; a = value.g; b = value.b; g = value.a; } }
        public vec4 gabb { get { return new vec4(g, a, b, b); } set { g = value.r; a = value.g; b = value.b; b = value.a; } }
        public vec4 gaba { get { return new vec4(g, a, b, a); } set { g = value.r; a = value.g; b = value.b; a = value.a; } }
        public vec4 gaar { get { return new vec4(g, a, a, r); } set { g = value.r; a = value.g; a = value.b; r = value.a; } }
        public vec4 gaag { get { return new vec4(g, a, a, g); } set { g = value.r; a = value.g; a = value.b; g = value.a; } }
        public vec4 gaab { get { return new vec4(g, a, a, b); } set { g = value.r; a = value.g; a = value.b; b = value.a; } }
        public vec4 gaaa { get { return new vec4(g, a, a, a); } set { g = value.r; a = value.g; a = value.b; a = value.a; } }
        public vec4 brrr { get { return new vec4(b, r, r, r); } set { b = value.r; r = value.g; r = value.b; r = value.a; } }
        public vec4 brrg { get { return new vec4(b, r, r, g); } set { b = value.r; r = value.g; r = value.b; g = value.a; } }
        public vec4 brrb { get { return new vec4(b, r, r, b); } set { b = value.r; r = value.g; r = value.b; b = value.a; } }
        public vec4 brra { get { return new vec4(b, r, r, a); } set { b = value.r; r = value.g; r = value.b; a = value.a; } }
        public vec4 brgr { get { return new vec4(b, r, g, r); } set { b = value.r; r = value.g; g = value.b; r = value.a; } }
        public vec4 brgg { get { return new vec4(b, r, g, g); } set { b = value.r; r = value.g; g = value.b; g = value.a; } }
        public vec4 brgb { get { return new vec4(b, r, g, b); } set { b = value.r; r = value.g; g = value.b; b = value.a; } }
        public vec4 brbr { get { return new vec4(b, r, b, r); } set { b = value.r; r = value.g; b = value.b; r = value.a; } }
        public vec4 brbg { get { return new vec4(b, r, b, g); } set { b = value.r; r = value.g; b = value.b; g = value.a; } }
        public vec4 brbb { get { return new vec4(b, r, b, b); } set { b = value.r; r = value.g; b = value.b; b = value.a; } }
        public vec4 brba { get { return new vec4(b, r, b, a); } set { b = value.r; r = value.g; b = value.b; a = value.a; } }
        public vec4 brar { get { return new vec4(b, r, a, r); } set { b = value.r; r = value.g; a = value.b; r = value.a; } }
        public vec4 brab { get { return new vec4(b, r, a, b); } set { b = value.r; r = value.g; a = value.b; b = value.a; } }
        public vec4 braa { get { return new vec4(b, r, a, a); } set { b = value.r; r = value.g; a = value.b; a = value.a; } }
        public vec4 bgrr { get { return new vec4(b, g, r, r); } set { b = value.r; g = value.g; r = value.b; r = value.a; } }
        public vec4 bgrg { get { return new vec4(b, g, r, g); } set { b = value.r; g = value.g; r = value.b; g = value.a; } }
        public vec4 bgrb { get { return new vec4(b, g, r, b); } set { b = value.r; g = value.g; r = value.b; b = value.a; } }
        public vec4 bggr { get { return new vec4(b, g, g, r); } set { b = value.r; g = value.g; g = value.b; r = value.a; } }
        public vec4 bggg { get { return new vec4(b, g, g, g); } set { b = value.r; g = value.g; g = value.b; g = value.a; } }
        public vec4 bggb { get { return new vec4(b, g, g, b); } set { b = value.r; g = value.g; g = value.b; b = value.a; } }
        public vec4 bgga { get { return new vec4(b, g, g, a); } set { b = value.r; g = value.g; g = value.b; a = value.a; } }
        public vec4 bgbr { get { return new vec4(b, g, b, r); } set { b = value.r; g = value.g; b = value.b; r = value.a; } }
        public vec4 bgbg { get { return new vec4(b, g, b, g); } set { b = value.r; g = value.g; b = value.b; g = value.a; } }
        public vec4 bgbb { get { return new vec4(b, g, b, b); } set { b = value.r; g = value.g; b = value.b; b = value.a; } }
        public vec4 bgba { get { return new vec4(b, g, b, a); } set { b = value.r; g = value.g; b = value.b; a = value.a; } }
        public vec4 bgag { get { return new vec4(b, g, a, g); } set { b = value.r; g = value.g; a = value.b; g = value.a; } }
        public vec4 bgab { get { return new vec4(b, g, a, b); } set { b = value.r; g = value.g; a = value.b; b = value.a; } }
        public vec4 bgaa { get { return new vec4(b, g, a, a); } set { b = value.r; g = value.g; a = value.b; a = value.a; } }
        public vec4 bbrr { get { return new vec4(b, b, r, r); } set { b = value.r; b = value.g; r = value.b; r = value.a; } }
        public vec4 bbrg { get { return new vec4(b, b, r, g); } set { b = value.r; b = value.g; r = value.b; g = value.a; } }
        public vec4 bbrb { get { return new vec4(b, b, r, b); } set { b = value.r; b = value.g; r = value.b; b = value.a; } }
        public vec4 bbra { get { return new vec4(b, b, r, a); } set { b = value.r; b = value.g; r = value.b; a = value.a; } }
        public vec4 bbgr { get { return new vec4(b, b, g, r); } set { b = value.r; b = value.g; g = value.b; r = value.a; } }
        public vec4 bbgg { get { return new vec4(b, b, g, g); } set { b = value.r; b = value.g; g = value.b; g = value.a; } }
        public vec4 bbgb { get { return new vec4(b, b, g, b); } set { b = value.r; b = value.g; g = value.b; b = value.a; } }
        public vec4 bbga { get { return new vec4(b, b, g, a); } set { b = value.r; b = value.g; g = value.b; a = value.a; } }
        public vec4 bbbr { get { return new vec4(b, b, b, r); } set { b = value.r; b = value.g; b = value.b; r = value.a; } }
        public vec4 bbbg { get { return new vec4(b, b, b, g); } set { b = value.r; b = value.g; b = value.b; g = value.a; } }
        public vec4 bbbb { get { return new vec4(b, b, b, b); } set { b = value.r; b = value.g; b = value.b; b = value.a; } }
        public vec4 bbba { get { return new vec4(b, b, b, a); } set { b = value.r; b = value.g; b = value.b; a = value.a; } }
        public vec4 bbar { get { return new vec4(b, b, a, r); } set { b = value.r; b = value.g; a = value.b; r = value.a; } }
        public vec4 bbag { get { return new vec4(b, b, a, g); } set { b = value.r; b = value.g; a = value.b; g = value.a; } }
        public vec4 bbab { get { return new vec4(b, b, a, b); } set { b = value.r; b = value.g; a = value.b; b = value.a; } }
        public vec4 bbaa { get { return new vec4(b, b, a, a); } set { b = value.r; b = value.g; a = value.b; a = value.a; } }
        public vec4 barr { get { return new vec4(b, a, r, r); } set { b = value.r; a = value.g; r = value.b; r = value.a; } }
        public vec4 barb { get { return new vec4(b, a, r, b); } set { b = value.r; a = value.g; r = value.b; b = value.a; } }
        public vec4 bara { get { return new vec4(b, a, r, a); } set { b = value.r; a = value.g; r = value.b; a = value.a; } }
        public vec4 bagg { get { return new vec4(b, a, g, g); } set { b = value.r; a = value.g; g = value.b; g = value.a; } }
        public vec4 bagb { get { return new vec4(b, a, g, b); } set { b = value.r; a = value.g; g = value.b; b = value.a; } }
        public vec4 baga { get { return new vec4(b, a, g, a); } set { b = value.r; a = value.g; g = value.b; a = value.a; } }
        public vec4 babr { get { return new vec4(b, a, b, r); } set { b = value.r; a = value.g; b = value.b; r = value.a; } }
        public vec4 babg { get { return new vec4(b, a, b, g); } set { b = value.r; a = value.g; b = value.b; g = value.a; } }
        public vec4 babb { get { return new vec4(b, a, b, b); } set { b = value.r; a = value.g; b = value.b; b = value.a; } }
        public vec4 baba { get { return new vec4(b, a, b, a); } set { b = value.r; a = value.g; b = value.b; a = value.a; } }
        public vec4 baar { get { return new vec4(b, a, a, r); } set { b = value.r; a = value.g; a = value.b; r = value.a; } }
        public vec4 baag { get { return new vec4(b, a, a, g); } set { b = value.r; a = value.g; a = value.b; g = value.a; } }
        public vec4 baab { get { return new vec4(b, a, a, b); } set { b = value.r; a = value.g; a = value.b; b = value.a; } }
        public vec4 baaa { get { return new vec4(b, a, a, a); } set { b = value.r; a = value.g; a = value.b; a = value.a; } }
        public vec4 arrr { get { return new vec4(a, r, r, r); } set { a = value.r; r = value.g; r = value.b; r = value.a; } }
        public vec4 arrg { get { return new vec4(a, r, r, g); } set { a = value.r; r = value.g; r = value.b; g = value.a; } }
        public vec4 arrb { get { return new vec4(a, r, r, b); } set { a = value.r; r = value.g; r = value.b; b = value.a; } }
        public vec4 arra { get { return new vec4(a, r, r, a); } set { a = value.r; r = value.g; r = value.b; a = value.a; } }
        public vec4 argr { get { return new vec4(a, r, g, r); } set { a = value.r; r = value.g; g = value.b; r = value.a; } }
        public vec4 argg { get { return new vec4(a, r, g, g); } set { a = value.r; r = value.g; g = value.b; g = value.a; } }
        public vec4 arga { get { return new vec4(a, r, g, a); } set { a = value.r; r = value.g; g = value.b; a = value.a; } }
        public vec4 arbr { get { return new vec4(a, r, b, r); } set { a = value.r; r = value.g; b = value.b; r = value.a; } }
        public vec4 arbb { get { return new vec4(a, r, b, b); } set { a = value.r; r = value.g; b = value.b; b = value.a; } }
        public vec4 arba { get { return new vec4(a, r, b, a); } set { a = value.r; r = value.g; b = value.b; a = value.a; } }
        public vec4 arar { get { return new vec4(a, r, a, r); } set { a = value.r; r = value.g; a = value.b; r = value.a; } }
        public vec4 arag { get { return new vec4(a, r, a, g); } set { a = value.r; r = value.g; a = value.b; g = value.a; } }
        public vec4 arab { get { return new vec4(a, r, a, b); } set { a = value.r; r = value.g; a = value.b; b = value.a; } }
        public vec4 araa { get { return new vec4(a, r, a, a); } set { a = value.r; r = value.g; a = value.b; a = value.a; } }
        public vec4 agrr { get { return new vec4(a, g, r, r); } set { a = value.r; g = value.g; r = value.b; r = value.a; } }
        public vec4 agrg { get { return new vec4(a, g, r, g); } set { a = value.r; g = value.g; r = value.b; g = value.a; } }
        public vec4 agra { get { return new vec4(a, g, r, a); } set { a = value.r; g = value.g; r = value.b; a = value.a; } }
        public vec4 aggr { get { return new vec4(a, g, g, r); } set { a = value.r; g = value.g; g = value.b; r = value.a; } }
        public vec4 aggg { get { return new vec4(a, g, g, g); } set { a = value.r; g = value.g; g = value.b; g = value.a; } }
        public vec4 aggb { get { return new vec4(a, g, g, b); } set { a = value.r; g = value.g; g = value.b; b = value.a; } }
        public vec4 agga { get { return new vec4(a, g, g, a); } set { a = value.r; g = value.g; g = value.b; a = value.a; } }
        public vec4 agbg { get { return new vec4(a, g, b, g); } set { a = value.r; g = value.g; b = value.b; g = value.a; } }
        public vec4 agbb { get { return new vec4(a, g, b, b); } set { a = value.r; g = value.g; b = value.b; b = value.a; } }
        public vec4 agba { get { return new vec4(a, g, b, a); } set { a = value.r; g = value.g; b = value.b; a = value.a; } }
        public vec4 agar { get { return new vec4(a, g, a, r); } set { a = value.r; g = value.g; a = value.b; r = value.a; } }
        public vec4 agag { get { return new vec4(a, g, a, g); } set { a = value.r; g = value.g; a = value.b; g = value.a; } }
        public vec4 agab { get { return new vec4(a, g, a, b); } set { a = value.r; g = value.g; a = value.b; b = value.a; } }
        public vec4 agaa { get { return new vec4(a, g, a, a); } set { a = value.r; g = value.g; a = value.b; a = value.a; } }
        public vec4 abrr { get { return new vec4(a, b, r, r); } set { a = value.r; b = value.g; r = value.b; r = value.a; } }
        public vec4 abrb { get { return new vec4(a, b, r, b); } set { a = value.r; b = value.g; r = value.b; b = value.a; } }
        public vec4 abra { get { return new vec4(a, b, r, a); } set { a = value.r; b = value.g; r = value.b; a = value.a; } }
        public vec4 abgg { get { return new vec4(a, b, g, g); } set { a = value.r; b = value.g; g = value.b; g = value.a; } }
        public vec4 abgb { get { return new vec4(a, b, g, b); } set { a = value.r; b = value.g; g = value.b; b = value.a; } }
        public vec4 abga { get { return new vec4(a, b, g, a); } set { a = value.r; b = value.g; g = value.b; a = value.a; } }
        public vec4 abbr { get { return new vec4(a, b, b, r); } set { a = value.r; b = value.g; b = value.b; r = value.a; } }
        public vec4 abbg { get { return new vec4(a, b, b, g); } set { a = value.r; b = value.g; b = value.b; g = value.a; } }
        public vec4 abbb { get { return new vec4(a, b, b, b); } set { a = value.r; b = value.g; b = value.b; b = value.a; } }
        public vec4 abba { get { return new vec4(a, b, b, a); } set { a = value.r; b = value.g; b = value.b; a = value.a; } }
        public vec4 abar { get { return new vec4(a, b, a, r); } set { a = value.r; b = value.g; a = value.b; r = value.a; } }
        public vec4 abag { get { return new vec4(a, b, a, g); } set { a = value.r; b = value.g; a = value.b; g = value.a; } }
        public vec4 abab { get { return new vec4(a, b, a, b); } set { a = value.r; b = value.g; a = value.b; b = value.a; } }
        public vec4 abaa { get { return new vec4(a, b, a, a); } set { a = value.r; b = value.g; a = value.b; a = value.a; } }
        public vec4 aarr { get { return new vec4(a, a, r, r); } set { a = value.r; a = value.g; r = value.b; r = value.a; } }
        public vec4 aarg { get { return new vec4(a, a, r, g); } set { a = value.r; a = value.g; r = value.b; g = value.a; } }
        public vec4 aarb { get { return new vec4(a, a, r, b); } set { a = value.r; a = value.g; r = value.b; b = value.a; } }
        public vec4 aara { get { return new vec4(a, a, r, a); } set { a = value.r; a = value.g; r = value.b; a = value.a; } }
        public vec4 aagr { get { return new vec4(a, a, g, r); } set { a = value.r; a = value.g; g = value.b; r = value.a; } }
        public vec4 aagg { get { return new vec4(a, a, g, g); } set { a = value.r; a = value.g; g = value.b; g = value.a; } }
        public vec4 aagb { get { return new vec4(a, a, g, b); } set { a = value.r; a = value.g; g = value.b; b = value.a; } }
        public vec4 aaga { get { return new vec4(a, a, g, a); } set { a = value.r; a = value.g; g = value.b; a = value.a; } }
        public vec4 aabr { get { return new vec4(a, a, b, r); } set { a = value.r; a = value.g; b = value.b; r = value.a; } }
        public vec4 aabg { get { return new vec4(a, a, b, g); } set { a = value.r; a = value.g; b = value.b; g = value.a; } }
        public vec4 aabb { get { return new vec4(a, a, b, b); } set { a = value.r; a = value.g; b = value.b; b = value.a; } }
        public vec4 aaba { get { return new vec4(a, a, b, a); } set { a = value.r; a = value.g; b = value.b; a = value.a; } }
        public vec4 aaar { get { return new vec4(a, a, a, r); } set { a = value.r; a = value.g; a = value.b; r = value.a; } }
        public vec4 aaag { get { return new vec4(a, a, a, g); } set { a = value.r; a = value.g; a = value.b; g = value.a; } }
        public vec4 aaab { get { return new vec4(a, a, a, b); } set { a = value.r; a = value.g; a = value.b; b = value.a; } }
        public vec4 aaaa { get { return new vec4(a, a, a, a); } set { a = value.r; a = value.g; a = value.b; a = value.a; } }
#endif
#endif
    }
}
#endif
#endif