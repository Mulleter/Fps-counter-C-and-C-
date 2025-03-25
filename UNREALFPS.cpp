#include "GameFramework/HUD.h"
#include "Engine/Canvas.h"
#include "Engine/Engine.h"

class AFPSHUD : public AHUD
{
public:
    virtual void DrawHUD() override
    {
        Super::DrawHUD();

        float FPS = 1.0f / GetWorld()->GetDeltaSeconds();
        FString FPSString = FString::Printf(TEXT("FPS: %.0f"), FPS);
        
        if (GEngine && Canvas)
        {
            Canvas->DrawText(GEngine->GetSmallFont(), FPSString, Canvas->ClipX - 100, 10);
        }
    }
};
