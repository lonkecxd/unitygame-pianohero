Shader "Custom/Alex"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
        _BaseColor("Base Color",Color)=(0.3, 0.4, 0.7, 1.0)
        _TargetColor("Target Color",Color)=(0.5,0.5,0.7,1.0)
        _BasePos("Base Pos",float)=-10
        _TargetPos("Target Pos",float)=10

    }

    SubShader
    {
        Tags{"RenderType" = "Opaque" }


        CGPROGRAM

        #pragma surface surf Lambert finalcolor:mycolor vertex:myvert

        struct Input
        {
            float2 uv_MainTex;
            half degree;
        };

        fixed4 _BaseColor;
        fixed4 _TargetColor;
        half _BasePos;
        half _TargetPos;
        sampler2D _MainTex;


        void myvert(inout appdata_full v,out Input data)
        {
            UNITY_INITIALIZE_OUTPUT(Input,data);
            float y=mul(unity_ObjectToWorld, v.vertex).y;
            data.degree=saturate((_BasePos-y)/(_BasePos-_TargetPos));
        }

        void mycolor(Input IN,SurfaceOutput o, inout fixed4 color)
        {
            fixed3 targetColor=_TargetColor.rgb;
            fixed3 baseColor=_BaseColor.rgb;
			color.rgb = lerp(color.rgb*baseColor, _TargetColor, IN.degree);
        }


        void surf(Input IN,inout SurfaceOutput o)
        {
            o.Albedo=tex2D(_MainTex, IN.uv_MainTex).rgb;
        }

        ENDCG



    }


    Fallback "Diffuse"

}