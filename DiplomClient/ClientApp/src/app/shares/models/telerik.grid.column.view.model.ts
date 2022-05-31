export interface TelerikGridColumnViewModel {
  id: string;
  templateId: string;
  propName: string;
  name: string;
  value: string;
  type: string;
  filterType: string;
  isEditable: boolean;
  order: number | undefined | null;
  width: number;
  isHidden: boolean;
}
