﻿# Change Log

<!--## Unreleased
- Support GetCurrentWindowHandle and GetWindowHandles-->



- Fix error response format
- Add `args` capability for launching application with arguments
- Set default elements search timeout to 10 seconds (fixed in [Winium.Cruciatus 2.7.0](https://github.com/2gis/Winium.Cruciatus/releases/tag/v2.7.0))
- Single file Driver distribution
- Add extended driver commands (see [Winium.Elements](https://github.com/2gis/Winium.Elements/releases) for bindings). Extended commands simplify usage of following elements:
 - ComboBox (collapse, expand, is expanded, find selected item, scroll to item)
 - DataGrid (row count, column count, find cell, scroll to cell, select cell)
 - ListBox (scroll to item)
 - Menu (find item, select item)


## v1.2.0

New features:
- Support Action Chains from bindings
- Add new script command for setting value to element using ValuePattern
