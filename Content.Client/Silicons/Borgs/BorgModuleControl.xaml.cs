// SPDX-FileCopyrightText: 2023 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Pieter-Jan Briers <pieterjan.briers+git@gmail.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Silicons.Borgs;

[GenerateTypedNameReferences]
public sealed partial class BorgModuleControl : PanelContainer
{
    public Action? RemoveButtonPressed;

    public BorgModuleControl(EntityUid entity, IEntityManager entityManager, bool canRemove)
    {
        RobustXamlLoader.Load(this);

        ModuleView.SetEntity(entity);
        ModuleName.Text = entityManager.GetComponent<MetaDataComponent>(entity).EntityName;
        RemoveButton.TexturePath = "/Textures/Interface/Nano/cross.svg.png";
        RemoveButton.OnPressed += _ =>
        {
            RemoveButtonPressed?.Invoke();
        };
        RemoveButton.Visible = canRemove;
    }
}
