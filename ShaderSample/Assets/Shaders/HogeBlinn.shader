Shader "Custom/HogeBlinn" {

	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf HogeBlinn
		#pragma target 3.0

 		struct Input {
			float2 uv_MainTex;
		};
 

		void surf (Input IN, inout SurfaceOutput  o) {
			o.Albedo = fixed4(1,1,1,1);
		}

		half4 LightingHogeBlinn(SurfaceOutput s, half3 lightDir, half3 viewDir, half atten)
		{
		//	H=(ViewDir + L)/|ViewDir+L|
			 half NdotL = max(0, dot (s.Normal, lightDir));
			 float3 H = normalize(viewDir + lightDir);
			 float3 spec = pow(max(0, dot(H, s.Normal)), 20.0);

			 half4 c;
			 c.rgb = s.Albedo * _LightColor0.rgb * NdotL + spec +  fixed4(0.1f, 0.1f, 0.1f, 1);
			 c.a = s.Alpha;
			 return c;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
